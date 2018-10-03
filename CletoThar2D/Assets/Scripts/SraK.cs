﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utilities2D;

public class SraK : MonoBehaviour {

    public float speed;
    public List<AxisPair> axes;
    private int fuji_veces = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        Vector3 movement = Vector3.zero;
        for (int i = 0; i < axes.Count; i++)
        {
            if(Input.GetKey(axes[i].keyCode) && !FindObstacle(axes[i].direction))
            {
                movement += axes[i].direction;
            }
        }

        movement = movement.normalized * speed * Time.deltaTime;
        transform.Translate(movement);
   
    }


	void OnTriggerEnter2D(Collider2D other)
	{
        if (other.CompareTag("SraK")) {
            Debug.Log("Fujimorizado");
            fuji_veces++;
            if (fuji_veces >= 5)
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(4);
             }
        }

         if (other.CompareTag("Goal")) {
            Debug.Log("Has alcanzado la meta");

            } else if (other.CompareTag("CamArea")) {
            	Camera.main.GetComponent<CamCtrl2D>().SwitchTarget (other.transform, 7);
            
            } else if (other.CompareTag("Collectable")) {
            	other.GetComponent<CollectableObject>().Collect();
            }
	}

	void OnTriggerExit2D (Collider2D other) {
		if (other.CompareTag("CamArea")) {
			Camera.main.GetComponent<CamCtrl2D>().SwitchTarget(null);
		}
	}



	void OnGUI(){
        GUI.Label(new Rect(0, 0, 100, 50), "Has sido Fujimorizado " + (fuji_veces) + " veces!");
        }


    bool FindObstacle(Vector3 direction)
    {
        RaycastHit2D[] hits2D = Physics2D.RaycastAll (transform.position, direction, 0.5f);
        Debug.DrawRay (transform.position, direction / 2, Color.blue, 2);

        foreach (RaycastHit2D hit2D in hits2D) {
        	if (hit2D.collider.CompareTag("walls")) {
        	return true;
       		 }
    }
    return false;
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