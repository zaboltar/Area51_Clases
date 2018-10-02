using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PivotRotation2D : EntityMov2D
{

    // este script ha sido cambiado en clase, pero uso una version anterior! ver repositorio. 

    public Vector2 currentPivotDirection;
    public float pivotDistance = 1f;

    // public Vector2 pivotDirection;

    // revisar esto xq me tira error, de hecho lo copie mal public Vector3 pivotPosition { get { return transform.position + ((Vector3)currentPivotDirection * pivotDistance)}};
    // almacena la formula

    // Use this for initialization
    void Start()
    {
      

    }

    // Update is called once per frame
    protected override void Update()
    {
        /*
        direction = (pivotPosition - transform.position).normalized;
        direction = Vector2.Perpendicular (direction);

        base.Update();

        currentPivotDirection -= (Vector2) movement / pivotDistance;
        Vector3 tempPivot = pivotPosition;
        transform.position = pivotPosition + ((transform.position - pivotPosition).normalized * pivotDistance);
        currentPivotDirection = (tempPivot - transform.position) / pivotDistance;

        Debug.Log(pivotPosition); */

        //revisar bien con el repositorio de Hilble esta parte; ya funciona bien !!



    }


    private void OnDrawGizmos()
    { /*
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(pivotPosition, 0.15f);
        Gizmos.DrawRay(transform.position, direction);
    */ 
     } 

}