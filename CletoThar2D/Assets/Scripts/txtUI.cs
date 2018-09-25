using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class txtUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	
	void OnGUI(){
        GUI.Label(new Rect(0, 0, 100, 50), "Stay Away From Walls");
}}
