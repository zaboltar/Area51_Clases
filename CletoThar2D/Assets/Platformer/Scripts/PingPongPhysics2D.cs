using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPongPhysics2D : EntityPhysics2D {

    public float distance = 1;
    private float currentDistance;

	
	

	protected override void FixedUpdate () {
        currentDistance += movement.magnitude;
        if (currentDistance >= distance) {
            	direction *= -1;
            	currentDistance = 0;
            }

            base.FixedUpdate();
        }
}
