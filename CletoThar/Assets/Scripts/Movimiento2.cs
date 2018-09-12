using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento2 : MonoBehaviour {

    public float speed = 5;

  	// Use this for initialization
	void Start () {

	}
    
	void Update () {

		//código de mov simple vertical
        if(Input.GetKey (KeyCode.UpArrow)) {
            transform.Translate (Vector3.forward * Time.deltaTime * speed);
            } else if (Input.GetKey (KeyCode.DownArrow))
        {
             transform.Translate (Vector3.back * Time.deltaTime * speed);
        }

        //código de mov simple horizontal
        if(Input.GetKey (KeyCode.LeftArrow)) {
            transform.position += Vector3.left * Time.deltaTime * speed;
        } else if (Input.GetKey (KeyCode.RightArrow)) {
            transform.position += Vector3.right * Time.deltaTime * speed;
        }
		      
	}

 
}