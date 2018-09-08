using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowScript : MonoBehaviour {

	public Transform target;
	public Vector3 offset;
		
	// Update is called once per frame
	void LateUpdate () {
		//if (target.position.y > transform.position.y)
		

			//Vector3 newPos = new Vector3(transform.position.x, transform.position.y,transform.position.z );
			//transform.position = newPos;
			transform.position = target.position + offset;
		

	}
}
