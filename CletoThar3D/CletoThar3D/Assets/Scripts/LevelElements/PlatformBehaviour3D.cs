using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBehaviour3D : Activatable {

    Vector3 startPoint;
    Vector3 currentTarget;
    public Vector3 targetPoint;
    public float speed;

    public Vector3 currentMomentum { get { return (currentTarget - transform.position).normalized * speed; }}

	// Use this for initialization
	void Start () {
        startPoint = transform.position;
        currentTarget = targetPoint;
	}
	
	// Update is called once per frame
	void Update () {

        if (transform.position == currentTarget) {
            currentTarget = (currentTarget == targetPoint) ? startPoint : targetPoint;
            // hasta antes de ? es la condicion del if, antes del : es la consecuencia o asignacion y luego del : es un else, osea la 
            // negacion de la condicion asignada.

        }
        
        transform.position = Vector3.MoveTowards(transform.position, currentTarget, speed * Time.deltaTime);

	}

    void OnDrawGizmos() {
        Gizmos.color = Color.blue;
        Gizmos.DrawCube(startPoint, Vector3.one * 0.25f);
        Gizmos.DrawCube(targetPoint, Vector3.one * 0.25f);

    }
}
