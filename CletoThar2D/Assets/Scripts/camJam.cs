using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camJam : MonoBehaviour {

	public Vector3 offset;
	public Transform target;
	
	void LateUpdate () {
		transform.position = target.position + offset;
	}
}

// ver gamasutra "scroll back the theory and practice of cameras in side scrollers"!