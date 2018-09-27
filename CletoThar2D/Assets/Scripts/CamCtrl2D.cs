using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamCtrl2D : MonoBehaviour {

    public Transform target;
    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, ConvertToCamDepth(target.position ) , speed * Time.deltaTime );


	}

    Vector3 ConvertToCamDepth (Vector3 vector) {
        return new Vector3(vector.x, vector.y, Camera.main.transform.position.z);
    }



}

// deberia solo seguirme en eje y
// debe tener limitaciones en eje x