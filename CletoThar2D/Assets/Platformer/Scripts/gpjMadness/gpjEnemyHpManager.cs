using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gpjEnemyHpManager : MonoBehaviour {

	public int maxHealth;
	public int currentHealth;
	private gpjPlayerStats thePlayerStats;
	public int expToGive;

	// Use this for initialization
	void Start () {

		currentHealth = maxHealth;
		
		thePlayerStats = FindObjectOfType<gpjPlayerStats>();
	}
	
	// Update is called once per frame
	void Update () {
		if (currentHealth <= 0) {
			Destroy(gameObject);
			thePlayerStats.AddExp(expToGive);
		}
	}

	public void HurtEnemy(int damageToGive){
		currentHealth -= damageToGive;
	}

	public void SetMaxHealth(){
		currentHealth = maxHealth;
	}

}
