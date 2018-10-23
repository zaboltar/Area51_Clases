using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gpjHurtEnemy : MonoBehaviour {

	public int damageToGive;
	public GameObject damageBurst;
	public Transform hitpoint;
	public GameObject damageNumber;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "dinoEnemy") {
			//Destroy(other.gameObject);
			other.gameObject.GetComponent<gpjEnemyHpManager>().HurtEnemy(damageToGive);
			Instantiate(damageBurst, hitpoint.position, hitpoint.rotation);
			var clone = (GameObject) Instantiate(damageNumber, hitpoint.position, Quaternion.Euler(Vector3.zero));
			clone.GetComponent<gpjFloatingNumbers>().damageNumber = damageToGive;

		}

	}




}
