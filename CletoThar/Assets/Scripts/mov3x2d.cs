using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//esto lo vi x ahí


public class mov3x2d : MonoBehaviour {



	public float moveSpeed = 32f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Input.GetAxis("Horizontal")*Time.deltaTime*moveSpeed, Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed, 0f);
	}
}
