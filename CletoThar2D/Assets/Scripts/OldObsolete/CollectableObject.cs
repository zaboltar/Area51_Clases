using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableObject : MonoBehaviour {


	void Awake() {
        GameControl.instance.objectiveInstances.Add (this);
	}
        

	public float points;

	public void Collect() {
		Debug.Log ("Eres más veloz!");
        GameControl.instance.CheckInstancePoint(this);
		Destroy (gameObject);
	}
}
