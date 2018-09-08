using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoControlado : MonoBehaviour {
    public float speed = 5;

  	// Use this for initialization
	void Start () {
    

    // por si se desconfigura
		// this.Rigidbody.useGravity = false;
	}		// pero no se como usarlo :p
	
	// Update is called once per frame
	void Update () {

		//código de mov simple vertical
        if(Input.GetKey (KeyCode.UpArrow)) {
            transform.position += Vector3.up * Time.deltaTime * speed ;
        } else if (Input.GetKey (KeyCode.DownArrow))
        {
            transform.position += Vector3.down * Time.deltaTime * speed;
        }

        //código de mov simple horizontal
        if(Input.GetKey (KeyCode.LeftArrow)) {
            transform.position += Vector3.left * Time.deltaTime * speed ;
        } else if (Input.GetKey (KeyCode.RightArrow))
        {
            transform.position += Vector3.right * Time.deltaTime * speed;
        }
		


	}
}
