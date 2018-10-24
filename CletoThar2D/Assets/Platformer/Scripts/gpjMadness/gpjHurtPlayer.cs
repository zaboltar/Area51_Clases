using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gpjHurtPlayer : MonoBehaviour {

	public int damageToGive;
	public GameObject dmgNumber;
	private int currentDamage;

	private gpjPlayerStats thePS;

	// Use this for initialization
	void Start () {
		thePS = FindObjectOfType<gpjPlayerStats>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Player") {

			currentDamage = damageToGive - thePS.currentDefence;
			if (currentDamage < 0) {
				currentDamage = 0;
			}

			other.gameObject.GetComponent<gpjHealthManager>().HurtPlayer(damageToGive);
			
			var clone = (GameObject) Instantiate(dmgNumber, other.transform.position, Quaternion.Euler(Vector3.zero));
			clone.GetComponent<gpjFloatingNumbers>().damageNumber = damageToGive;

			}
	}
}
