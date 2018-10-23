using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gpjHealthManager : MonoBehaviour {


	public int playerMaxHealth;
	public int playerCurrentHealth;
	
	// Use this for initialization
	void Start () {

		playerCurrentHealth = playerMaxHealth;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (playerCurrentHealth <= 0) {
			UnityEngine.SceneManagement.SceneManager.LoadScene(8);  
		}
	}

	public void HurtPlayer(int damageToGive){
		playerCurrentHealth = playerCurrentHealth - damageToGive;
	}

	public void SetMaxHealth(){
		playerCurrentHealth = playerMaxHealth;
	}



}
