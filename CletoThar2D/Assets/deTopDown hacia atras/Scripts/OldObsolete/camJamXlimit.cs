using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camJamXlimit : MonoBehaviour {

	public Vector3 offset;
	public Transform target;
	
	void LateUpdate () {
        Vector3 temp = transform.position;

        temp.y = target.position.y;
        temp.z = offset.z;

        transform.position = temp;

        // con esto he limitado el eje X y sòlo se mueve en Y !!!
        // rehacer este script para no alterar el original
	}
}

// ver gamasutra "scroll back the theory and practice of cameras in side scrollers"!