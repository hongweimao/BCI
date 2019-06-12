//
// Communicate with MessageManager 
//   to receive commands and send feedback   
// Hongwei Mao, University of Pittsburgh
//

using UnityEngine;
using System;
using System.IO;
using System.Runtime.InteropServices;
using UnityDragonfly;
using Dragonfly;

public class GameController : MonoBehaviour {

    // Dragonfly
    private string mm_ip        = "127.0.0.1:7111";
    private CSDragonfly csdf    = new CSDragonfly();
    private CSDragonfly.ReadType readType = CSDragonfly.ReadType.NonBlocking;
    public bool connected       = false;

    // Log output to file
    private bool verbose        = false;
    private string logFile      = "Unity_log.txt";
    private StreamWriter logger;

    // All gameObjects controlled via Dragonfly
    private TargetController    tgtCtrl;
    private CursorController    cursorCtrl;

    // Task related variables
    private Vector3 tgtPos      = new Vector3(-0.45f, -0.45f, 0.45f);
    private Vector3 cursorPos   = new Vector3(0f, 0f, 0f);
    private int taskStateID     = 0;
    private int cmdSerialNo     = 0;


    // Use this for initialization
    void Awake()
    {
        Application.runInBackground = true;

        if (verbose)
            logger = new StreamWriter(logFile, false);      // true to append, false to overwrite

        //---------------------------------------------------------------
        // Get gameObjects
        //---------------------------------------------------------------
        tgtCtrl = GameObject.Find("Target").GetComponent<TargetController>();
        cursorCtrl = GameObject.Find("Cursor").GetComponent<CursorController>();

        //---------------------------------------------------------------
        tgtCtrl.SetPos(tgtPos);

        //---------------------------------------------------------------
        // Connect to Dragonfly
        //---------------------------------------------------------------
        string[] arguments = Environment.GetCommandLineArgs();
        for (int i = 0; i < arguments.Length; i++)
        {
            if (verbose)
                logger.WriteLine("ARG " + i + ": " + arguments[i]);
        }
        if (arguments.Length >= 2)
            mm_ip = arguments[1];

        csdf.CreateModule();
        csdf.ConnectToMMM(MID.DENSO_MOD, mm_ip);
        if (csdf.IsConnected() == 0)
        {
            if (verbose)
                logger.WriteLine("Not connected to Dragonfly!");
        }
        else
        {
            if (verbose)
                logger.WriteLine("Connected to MM!");
            connected = true;

            csdf.Subscribe(MT.TRIAL_CONFIG);
            // csdf.Subscribe(MT.SAMPLE_GENERATED);
            csdf.Subscribe(MT.TASK_STATE_CONFIG);
            csdf.Subscribe(MT.COMPOSITE_MOVEMENT_COMMAND);
            csdf.Subscribe(MT.PING);
        }
    }


    void Update()
    {
        // process messages from Dragonfly
        if (connected == true)
        {
            while (csdf.ReadMessage(readType) > 0)
            {
                switch (csdf.inMsgType)
                {
                    case MT.TRIAL_CONFIG:
                        MDF.TRIAL_CONFIG tc = new MDF.TRIAL_CONFIG();
                        Marshal.PtrToStructure(csdf.pMsgIn, tc);

                        if (verbose)
                            logger.WriteLine("----- Block " + tc.rep_no + " Trial " + tc.trial_no + " -----");

                        // this is the start of a new trial, so reset cursor position back to center
                        cursorCtrl.SetPos(0f, 0f, 0f);

                        break;

                    case MT.TASK_STATE_CONFIG:
                        MDF.TASK_STATE_CONFIG tsc = new MDF.TASK_STATE_CONFIG();
                        Marshal.PtrToStructure(csdf.pMsgIn, tsc);

                        taskStateID = tsc.id;

                        Vector3 tgtPos = new Vector3(Convert.ToSingle(tsc.target[0]),
                                                     Convert.ToSingle(tsc.target[1]),
                                                     Convert.ToSingle(tsc.target[2]));

                        tgtCtrl.SetPos(tgtPos);

                        break;

                    case MT.COMPOSITE_MOVEMENT_COMMAND:
                        MDF.COMPOSITE_MOVEMENT_COMMAND cmc = new MDF.COMPOSITE_MOVEMENT_COMMAND();
                        Marshal.PtrToStructure(csdf.pMsgIn, cmc);

                        // integrate velocity to get position
                        double dt = cmc.sample_header.DeltaTime;
                        cmdSerialNo = cmc.sample_header.SerialNo;
                        cursorPos.x = Convert.ToSingle(cursorPos.x + cmc.vel[0] * dt);
                        cursorPos.y = Convert.ToSingle(cursorPos.y + cmc.vel[1] * dt);
                        cursorPos.z = Convert.ToSingle(cursorPos.z + cmc.vel[2] * dt);

                        // set cursor position
                        if (!Single.IsNaN(cursorPos.x))
                            cursorCtrl.SetPos(cursorPos.x, cursorPos.y, cursorPos.z);

                        cursorCtrl.sendFeedback = true;

                        break;

                    case MT.PING:

                        break;
                }

                // Free unmanaged memory
                csdf.DeleteReceivedMsg();
            }
        }
    }

    public void SendVRActualState(Vector3 fbkPos)
    {
        if (connected)
        {
            MDF.ROBOT_CONTROL_SPACE_ACTUAL_STATE vcsas = new MDF.ROBOT_CONTROL_SPACE_ACTUAL_STATE();
            vcsas.sample_header.SerialNo = cmdSerialNo;
            vcsas.pos[0] = fbkPos.x;
            vcsas.pos[1] = fbkPos.y;
            vcsas.pos[2] = fbkPos.z;
            csdf.SendMessage(MT.ROBOT_CONTROL_SPACE_ACTUAL_STATE, vcsas);
        }
    }

    public void SendJudgeVerdictMsg(string reason)
    {
        if (connected)
        {
            MDF.JUDGE_VERDICT jv = new MDF.JUDGE_VERDICT();
            jv.id = taskStateID;
            for (int i = 0; i < reason.Length; i++)
                jv.reason[i] = Convert.ToSByte(reason[i]);
            csdf.SendMessage(MT.JUDGE_VERDICT, jv);
        }
    }

    void OnApplicationQuit()
    {
        csdf.DisconnectFromMMM();

        if (verbose)
        {
            logger.WriteLine("bye bye");
            logger.Close();
        }
    }

}
