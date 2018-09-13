using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento2 : MonoBehaviour {

    public float speed = 15;
    public float angSpeed = 40;

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
        if (Input.GetKey (KeyCode.LeftArrow)) { transform.Rotate (Vector3.down * Time.deltaTime * angSpeed );}

        else if (Input.GetKey (KeyCode.RightArrow)) { transform.Rotate (Vector3.up * Time.deltaTime * angSpeed );}

       
		      
	}

 
}