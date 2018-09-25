using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PivotRotation2D : EntityMov2D {


    public Vector2 pivotDirection;
    public float pivotDistance = 1f;
    private Vector2 currentPivotDirection;

    public Vector3 pivotPosition;

	// Use this for initialization
	void Start () {
        currentPivotDirection = pivotDirection;
        pivotPosition = transform.position + ((Vector3)currentPivotDirection * pivotDistance);

	}
	
	// Update is called once per frame
	protected override void Update () {



        direction = (pivotPosition - transform.position).normalized;
        direction = Vector2.Perpendicular(direction);

        base.Update();

	}


	private void OnDrawGizmos()
	{
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(pivotPosition, 0.15f);
        Gizmos.DrawRay(transform.position, direction);
	}

}
