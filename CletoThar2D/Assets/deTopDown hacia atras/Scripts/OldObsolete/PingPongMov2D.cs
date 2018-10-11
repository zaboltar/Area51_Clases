using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPongMov2D : EntityMov2D {

    public float distance = 1;
    private float currentDistance;

	// Use this for initialization
	void Start () {
		
	}

	protected override void Update()
	{
        currentDistance += movement.magnitude;
        if (currentDistance >= distance) {
            direction *= -1;
            currentDistance = 0;
        }


        base.Update();
        //base update es el heredado de entitymov2d, esta overrided

	}
}
