using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTargetBehaviour : MonoBehaviour
{

    public Vector2 localMousePos { get { return Camera.main.ScreenToWorldPoint(Input.mousePosition); }}
    //usamos vector 2 a pesar de que es contraintuitivo, del v2 se toma el z del v3 del player, lo asume.
    public Vector3 mouseDirectionNormalized { get { return (localMousePos - (Vector2)transform.position).normalized; }}
    public float distanceDelta {get { return ( localMousePos - (Vector2)transform.position).magnitude; }}

    public Transform targetObject;

	// Use this for initialization
	void Start () {
        targetObject.gameObject.SetActive(true);	
	}
	
	// Update is called once per frame
	void Update () {

        targetObject.position = localMousePos;

        Debug.DrawLine (transform.position, localMousePos, Color.cyan);
	}

	/*private void OnDrawGizmos() {
        Gizmos.color = Color.cyan;
        Gizmos.DrawLine(transform.position, localMousePos);

	}*/




}
