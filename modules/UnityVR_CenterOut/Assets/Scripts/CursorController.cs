//
// Control cursor behavior
// Hongwei Mao, University of Pittsburgh
//

using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
using System.Linq;


public class CursorController : MonoBehaviour {

    // MessageManager has a communicating channel to send feedback to Dragonfly
    private GameController gameCtrl;

    // hand/cursor properties
    //private Rigidbody rb;
    private Collider col;
    private MeshRenderer mr;

    public Vector3 cursorPos        = Vector3.zero;
    private Color cursorColor;

    // Cameras objects to get field of view
    public bool     stereoView      = true;
    private Camera  leftCamera;
    private Camera  rightCamera;
    private Camera  monoCamera;
    private Plane[] leftCamPlanes;
    private Plane[] rightCamPlanes;
    private Plane[] monoCamPlanes;
    public bool     jvOutOfFOV      = false;
    public bool     sendFeedback    = false;
    

    void Start () {

        //rb          = transform.GetComponent<Rigidbody>();
        col         = GetComponent<Collider>();
        mr          = GetComponent<MeshRenderer>();
        cursorPos   = transform.position;
        cursorColor = mr.material.color;

        // Get Camera frustum planes
        // OffCenterCam should run before this script in execution order
        if (stereoView == true) // stereo view
        {
            leftCamera = GameObject.Find("LeftCam").GetComponent<Camera>();
            rightCamera = GameObject.Find("RightCam").GetComponent<Camera>();
            leftCamPlanes = GeometryUtility.CalculateFrustumPlanes(leftCamera);
            rightCamPlanes = GeometryUtility.CalculateFrustumPlanes(rightCamera);
        }
        else // monocular view
        {
            monoCamera = GameObject.Find("CenterCam").GetComponent<Camera>();
            monoCamPlanes = GeometryUtility.CalculateFrustumPlanes(monoCamera);
        }

        gameCtrl = GameObject.Find("GameControl").GetComponent<GameController>();

    }

	void OnApplicationQuit() {
		//dragonfly.Close ();
		//Debug.Log ("bye bye");
	}

    // Process received commands and take care of hand/cursor-object interaction
    void Update()
    {
        //rb.position  = cursorPos;
        transform.position = cursorPos;

        // send feedback
        if (sendFeedback)
        {
            gameCtrl.SendVRActualState(cursorPos);
            sendFeedback = false;
        }

        // check to see if hand is out of camera's field of view
        jvOutOfFOV = false;
        if (stereoView == true)
        {
            if (!GeometryUtility.TestPlanesAABB(leftCamPlanes, col.bounds) ||
                !GeometryUtility.TestPlanesAABB(rightCamPlanes, col.bounds))
                jvOutOfFOV = true;
        }
        else
        {
            if (!GeometryUtility.TestPlanesAABB(monoCamPlanes, col.bounds))
                jvOutOfFOV = true;
        }

        if (gameCtrl.connected == true)
        {
            if (jvOutOfFOV == true)
            {
                string reason = "OUT_OF_FOV";
                gameCtrl.SendJudgeVerdictMsg(reason);
            }
        }    
    }

    public void SetPos(float x, float y, float z)
    {
        cursorPos.x = x;
        cursorPos.y = y;
        cursorPos.z = z;
    }

    public void SetScale(float x, float y, float z)
    {
        Vector3 cs = new Vector3(x, y, z);
        gameObject.transform.localScale = cs;
    }

    public void SetColor(float r, float g, float b)
    {
        cursorColor.r = r;
        cursorColor.g = g;
        cursorColor.b = b;

        mr.material.color = cursorColor;
    }

}
