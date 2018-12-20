using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {


	public Texture itemTexture;
	public bool craftMaterial;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.F) && !craftMaterial){
			this.gameObject.SetActive(false);
		}
	}
}
