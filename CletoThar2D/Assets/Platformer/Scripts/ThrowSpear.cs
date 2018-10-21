﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowSpear : MonoBehaviour {

public GameObject shot;
	private Transform playerPos;
	 public Animator anim4;

	void Start(){
		playerPos = GetComponent<Transform>();
	}


	
	void Update () {
		if(Input.GetMouseButtonDown(0)){



			Instantiate(shot, playerPos.position, Quaternion.identity);
			anim4.SetBool ("Att4", true);
			
		} else {
			anim4.SetBool ("Att4", false);
		}
	}
}