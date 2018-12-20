using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	//VARIABLES

	private float hunger, thirst, health;
	public float maxHunger, maxThirst, maxHealth;

	public float hungerIncrease, thirstIncrease;

	//FUNCTIONS

	void Start () {

		health = maxHealth;
	}

	void Update() {

		//thirst n hunger
		HungerAndThirst();

		//player health management
		if (health <= 0) {
			Die();
		}
		


	}

	public void HungerAndThirst(){

		hunger += hungerIncrease * Time.deltaTime;
		thirst += thirstIncrease * Time.deltaTime;

			if (hunger >= maxHunger){
				 Die();
			}

			if (thirst >= maxThirst){
				 Die();
			}
	}		

	public void Die(){
		print("Player is dead");
	}

	
	


}
