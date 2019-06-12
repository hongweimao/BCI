//
// Import Dragonfly library for Unity C#
// Hongwei Mao, University of Pittsburgh
//

using System;
using UnityEngine;
using System.Runtime.InteropServices;
using Dragonfly;

namespace UnityDragonfly
{
    public class CSDragonfly
    {
        // a local copy of the pointer to a native Dragonfly_Module instance
        private IntPtr mod      = IntPtr.Zero;
        // info of the incoming message (for ReadMessage)
        public IntPtr pMsgIn    = IntPtr.Zero;
        public int inMsgType    = -100;
        public int inNumBytes   = 0;
        // info of the outgoing message (for SendMessage)
        public IntPtr pMsgOut   = IntPtr.Zero;
        public int outMsgType   = -100;
        public int outNumBytes  = 0;

        public enum ReadType{Blocking, NonBlocking};

        public void CreateModule()
        {
            mod = Native_Module();
        }

        public void DestroyModule()
        {
            Native_DestroyModule(mod);
        }

        public int ConnectToMMM(short ModuleID, string ServerName)
        {
            return Native_ConnectToMMM(mod, ModuleID, ServerName);
        }

        public void DisconnectFromMMM()
        {
            Native_DisconnectFromMMM(mod);
        }

        public int IsConnected()
        {
            return Native_IsConnected(mod);
        }

        public int Subscribe(int MessageType)
        {
            return Native_Subscribe(mod, MessageType);
        }

        // receive Dragonfly message
        public int ReadMessage(ReadType BlockingOrNot)
        {
            double timeout = 0;
            switch (BlockingOrNot)
            {
                case ReadType.Blocking:
                    timeout = -1.0;
                    break;
                case ReadType.NonBlocking:
                    timeout = 0.0;
                    break;
                default:
                    timeout = 0.0;
                    break;
            }

            try
            {
                inMsgType = Native_ReadMessage(mod, timeout, out pMsgIn, ref inNumBytes);

                // process native-function-side exceptions via return values
                if (inMsgType == -2)
                    throw new Exception("Unity is not connected to MM!");
                else if (inMsgType == -3)
                    throw new Exception("Failed to allocate memory for message data!");
                else if (inMsgType == -1)
                {
                    //Debug.Log("No message received.");
                }

            }
            catch (Exception e)
            {
                Debug.LogException(e);
            }

            return inMsgType;
        }

        // free unmanaged memory that holds message data
        public void DeleteReceivedMsg()
        {
            if (pMsgIn != IntPtr.Zero)
                Native_FreeMemory(pMsgIn);
            else
                Debug.Log("No memory needs to be freed!");

            pMsgIn      = IntPtr.Zero;
            inMsgType   = -100;
            inNumBytes  = 0;
        }

        // send Dragonfly message
        public void SendMessage(int MessageType, System.Object MessageData)
        {
            int res_native  = 0;
            outMsgType = MessageType;

            try
            {
                // get the size of the message
                // *** explicitly list all potential Dragonfly messages that Unity may send ***
                if (outMsgType == MT.ROBOT_CONTROL_SPACE_ACTUAL_STATE)
                    outNumBytes = Marshal.SizeOf((MDF.ROBOT_CONTROL_SPACE_ACTUAL_STATE) MessageData);
                else if (outMsgType == MT.JUDGE_VERDICT)
                    outNumBytes = Marshal.SizeOf((MDF.JUDGE_VERDICT) MessageData);
                else
                    throw new Exception("SendMessage: Unrecognized message type, ID = " + outMsgType + ".");

                // allocate unmanaged memory
                pMsgOut = Marshal.AllocHGlobal(outNumBytes);
                // marshal message data to unmanaged memory
                Marshal.StructureToPtr(MessageData, pMsgOut, false);

                // invoke native SendMessage method
                res_native = Native_SendMessage(mod, outMsgType, pMsgOut, outNumBytes);

                // process native-function-side exceptions via return values
                if (res_native == -1)
                    throw new Exception("Unity is not connected to MM!");
                else if (res_native == 0)
                    throw new Exception("Failed to send message, ID = " + outMsgType);
            }
            catch (Exception e)
            {
                Debug.LogException(e);
            }
            finally
            {
                // free previously allocated unmanaged memory
                Marshal.FreeHGlobal(pMsgOut);

                pMsgOut     = IntPtr.Zero;
                outMsgType  = -100;
                outNumBytes = 0;
            }
        }

        //-------------------------------------------------------
        // DllImport function declaration for Unity to invoke
        //-------------------------------------------------------
        [DllImport("Dragonfly.Unity")]
        private static extern IntPtr Native_Module();

        [DllImport("Dragonfly.Unity")]
        private static extern void Native_DestroyModule(IntPtr mod);

        [DllImport("Dragonfly.Unity")]
        private static extern int Native_ConnectToMMM(IntPtr mod, short moduleID, string serverName);

        [DllImport("Dragonfly.Unity")]
        private static extern void Native_DisconnectFromMMM(IntPtr mod);

        [DllImport("Dragonfly.Unity")]
        private static extern int Native_IsConnected(IntPtr mod);

        [DllImport("Dragonfly.Unity")]
        private static extern int Native_Subscribe(IntPtr mod, int messageType);

        [DllImport("Dragonfly.Unity")]
        private static extern int Native_ReadMessage(IntPtr mod, double timeout, out IntPtr MessageData, ref int numBytes);

        [DllImport("Dragonfly.Unity")]
        private static extern void Native_FreeMemory(IntPtr MessageData);

        [DllImport("Dragonfly.Unity")]
        private static extern int Native_SendMessage(IntPtr mod, int messageType, IntPtr MessageData, int numBytes);
    }
}
