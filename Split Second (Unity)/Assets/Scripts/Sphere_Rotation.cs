using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere_Rotation : MonoBehaviour {

    public bool leftOrbit;
    public bool rightOrbit;
    public bool main;
    public Vector3 mainObject;
    public GameObject mainObject2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (main)
        {
            transform.Rotate(Vector3.right, 100 * Time.deltaTime);
        }
        else if (leftOrbit)
        {
            transform.RotateAround(mainObject, Vector3.right, 250 * Time.deltaTime);
            transform.RotateAround(mainObject, Vector3.up, 250 * Time.deltaTime);
        }
        else if (rightOrbit)
        {
            transform.RotateAround(mainObject, Vector3.left, 250 * Time.deltaTime);
            transform.RotateAround(mainObject, Vector3.down, -250 * Time.deltaTime);
        }
       
    }
}
