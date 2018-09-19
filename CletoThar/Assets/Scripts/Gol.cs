using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gol : MonoBehaviour {

	void OnTriggerEnter (Collider other) {
		if (other.CompareTag("BALL")){
			Debug.Log ("GOOOOL!");
		}
	}
}
