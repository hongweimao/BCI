//
// Control target behavior
// Hongwei Mao, University of Pittsburgh
//

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TargetController : MonoBehaviour {

    private MeshRenderer mr;
    private Color tgtColor;
    
	void Start() {
        // gameObject components
        mr = GetComponent<MeshRenderer>();
        tgtColor = mr.material.color;
    }

	void Update() {

    }

    public void SetPos(Vector3 pos)
    {
        transform.position = pos;
    }

    public void SetScale(float x, float y, float z)
    {
        Vector3 cs = new Vector3(x, y, z);
        gameObject.transform.localScale = cs;
    }

    public void SetColor(float r, float g, float b)
    {
        tgtColor.r = r;
        tgtColor.g = g;
        tgtColor.b = b;
        mr.material.color = tgtColor;
    }

    private void OnTriggerEnter(Collider col)
    {
        ProcessCollision(col);
    }

    private void OnTriggerStay(Collider col)
    {
        ProcessCollision(col);
    }

    private void OnTriggerExit(Collider col)
    {
        tgtColor.a = 1.0f;
        mr.material.color = tgtColor;
    }

    private void ProcessCollision(Collider col)
    {
        // make object semi-transparent to indicate contact
        tgtColor.a = 0.4f;
        mr.material.color = tgtColor;
    }
}
