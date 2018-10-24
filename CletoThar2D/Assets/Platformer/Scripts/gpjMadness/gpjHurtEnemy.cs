using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gpjHurtEnemy : MonoBehaviour {

	public int damageToGive;
	private int currentDamage;
	public GameObject damageBurst;
	public Transform hitpoint;
	public GameObject damageNumber;

	private gpjPlayerStats thePS;

	// Use this for initialization
	void Start () {
		thePS = FindObjectOfType<gpjPlayerStats>();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "dinoEnemy") {
			//Destroy(other.gameObject);
			currentDamage = damageToGive + thePS.currentAttack;

			other.gameObject.GetComponent<gpjEnemyHpManager>().HurtEnemy(currentDamage);
			Instantiate(damageBurst, hitpoint.position, hitpoint.rotation);
			var clone = (GameObject) Instantiate(damageNumber, hitpoint.position, Quaternion.Euler(Vector3.zero));
			clone.GetComponent<gpjFloatingNumbers>().damageNumber = currentDamage;

		}

	}




}
