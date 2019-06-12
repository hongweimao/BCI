//
// Set camera frustum
// Hongwei Mao, University of Pittsburgh
//

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Set camera projection matrix
public class OffCenterCam : MonoBehaviour {

    private Camera cam;
    private Matrix4x4 projMat;
    private float near;
    private float far;
    private float offset;               // = d/2, d is the distance between two eyes
    private Resolution r;
    private float camZ;                 // Z location of the camera
    // these two variables control camera's field of view
    private float focalHeight = 1.50f;  // height (in Y) of the focal plane
    private float focalZ = 0f;          // Z location of the focal plane
    
    void Awake()
    {
        QualitySettings.vSyncCount  = 0;
        Application.targetFrameRate = 60;
    }

    // Use this for initialization
    void Start () {
        cam     = GetComponent<Camera>();

        near    = cam.nearClipPlane;
        far     = cam.farClipPlane;
        offset  = transform.position.x;
        camZ    = transform.position.z;

        //r = Screen.currentResolution;
        // use 3D monitor's resolution as screen resolution
        r.width = 1920;         r.height = 1080;
        //r.width = 1024;         r.height = 768;

        projMat = PerspectiveOffCenter(focalHeight, focalZ, camZ, offset, near, far, r);

        cam.projectionMatrix = projMat;
    }
	
	void Update () {
        
    }

    // Set an off-center projection, where perspective's vanishing point is not necessarily in the center of the screen.
    //
    // left/right/top/bottom define near plane size, i.e. how offset are corners of camera's near plane.
    // Tweak the values and you can see camera's frustum change.
    static Matrix4x4 PerspectiveOffCenter(float focalHeight, float focalZ, float camZ, float offset, float near, float far, Resolution r)
    {
        float focalLen      = Mathf.Abs(focalZ - camZ);
        float focalWidth    = r.width * focalHeight / r.height;

        float left   = -near * (focalWidth / 2 + offset) / focalLen;
        float right  =  near * (focalWidth / 2 - offset) / focalLen;
        float top    =  focalHeight * near / 2f / focalLen;
        float bottom = -top;

        // code from Unity documentation
        float x = 2.0F * near / (right - left);
        float y = 2.0F * near / (top - bottom);
        float a = (right + left) / (right - left);
        float b = (top + bottom) / (top - bottom);
        float c = -(far + near) / (far - near);
        float d = -(2.0F * far * near) / (far - near);
        float e = -1.0F;
        Matrix4x4 m = new Matrix4x4();
        m[0, 0] = x;
        m[0, 1] = 0;
        m[0, 2] = a;
        m[0, 3] = 0;
        m[1, 0] = 0;
        m[1, 1] = y;
        m[1, 2] = b;
        m[1, 3] = 0;
        m[2, 0] = 0;
        m[2, 1] = 0;
        m[2, 2] = c;
        m[2, 3] = d;
        m[3, 0] = 0;
        m[3, 1] = 0;
        m[3, 2] = e;
        m[3, 3] = 0;
        return m;
    }
}
