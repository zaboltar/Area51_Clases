using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoControlado : MonoBehaviour {
    public float speed = 2;

  	// Use this for initialization
	void Start () {
                    
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey (KeyCode.UpArrow)) {
            transform.position += Vector3.up * Time.deltaTime * speed ;
        } else if (Input.GetKey (KeyCode.DownArrow))
        {
            transform.position += Vector3.down * Time.deltaTime * speed;
        }
		
	}
}
