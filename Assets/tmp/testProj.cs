using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testProj : MonoBehaviour {

    public Transform t;
    public Vector3 gravity;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        Vector3 Y = Vector3.Project(gravity, t.up);
        Vector3 X = Vector3.Project(gravity, t.right);
        Vector3 Z = Vector3.Project(gravity, t.forward);

        Vector3 relativePointY = t.InverseTransformPoint(t.position + Y);
        Vector3 relativePointX = t.InverseTransformPoint(t.position + X);
        Vector3 relativePointZ = t.InverseTransformPoint(t.position + Z);

        //print(relativePointY);

        Gizmos.color = Color.blue;
        Gizmos.DrawLine(t.position, t.position + 2f * Z);

        Gizmos.color = Color.red;
        Gizmos.DrawLine(t.position, t.position + 2f * X);

        Gizmos.color = Color.green;
        Gizmos.DrawLine(t.position, t.position + 2f * Y);
    }
}
