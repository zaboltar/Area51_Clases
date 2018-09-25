﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utilities2D;

public class MovContinuo : MonoBehaviour {

    public float speed;
    public List<AxisPair> axes;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 movement = Vector3.zero;
        for (int i = 0; i < axes.Count; i++)
        {
            if(Input.GetKey(axes[i].keyCode)){
                movement += axes[i].direction;
            }
        }

        movement = movement.normalized * speed * Time.deltaTime;
        transform.Translate(movement);
    }

	private void OnTriggerEnter2D(Collider2D other)
	{
        if (other.CompareTag("SraK")) {
            Debug.Log("Fujimorizado");
        }
	}

}

// no es muy eficiente recurrir a la variacion del velocity para el movimiento, es mejor usar rigidbody
// se puede alterar el velocity con metodos de rigidbody, como addforce
// mov en 2d es distinto de 3d, recurren a metodos que esencialmente son distintos
// en add force; force es como una propulsiòn 
// el impulso presupone ya una mov (y es una fuerza añadida?)
// en ambos casos hay aceleracion pero en propulsion hay velo 0 y en impulso no
// addforce permite mayor naturalidad.

// equivalente al transform.Translate es rigidbody.move