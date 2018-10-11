using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextColNRayCst : MonoBehaviour {

    float distance = 20f;
    Vector3 source, target;

	// Use this for initialization
	void Start () {
        target = Vector3.forward * distance;
	}
	
	// Update is called once per frame
    void Update () {
        source = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        RaycastHit2D hit2D = Physics2D.Raycast(source, target);
	
        if (hit2D){
            Debug.Log(hit2D.collider.name);
        }
    }


	void OnGUI(){
        GUI.Label(new Rect(0, 0, 100, 50), "This is a label");	
	}

	void OnDrawGizmos(){
        Gizmos.color = Color.red;
        Gizmos.DrawRay (source, target);

	}





}
