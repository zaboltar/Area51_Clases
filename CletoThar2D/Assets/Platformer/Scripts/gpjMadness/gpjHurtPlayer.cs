using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gpjHurtPlayer : MonoBehaviour {

	public int damageToGive;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Player") {
			other.gameObject.GetComponent<gpjHealthManager>().HurtPlayer(damageToGive);
			}
	}
}
