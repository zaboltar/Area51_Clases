using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPongPhysics2D : EntityPhysics2D {

    public float distance = 1;
    private float currentDistance;

	
	//revisar, corregir

	// Update is called once per frame
	protected override void FixedUpdate () {
        currentDistance += movement.magnitude;
        if (currentDistance >= distance) {
            //direction 
        }
		
	}
}
