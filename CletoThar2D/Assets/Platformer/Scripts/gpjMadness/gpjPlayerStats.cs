using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gpjPlayerStats : MonoBehaviour {

	public int currentLevel;

	public int currentExp;

	public int[] toLevelUp;

	public int[] HPLevels;
	public int[] attackLevels;
	public int[] defenceLevels;

	public int currentHp;
	public int currentAttack;
	public int currentDefence;

	private gpjHealthManager thePlayerHealth;


	// Use this for initialization
	void Start () {
		currentHp = HPLevels[1];
		currentAttack = attackLevels[1];
		currentDefence = defenceLevels[1];

		thePlayerHealth = FindObjectOfType<gpjHealthManager>();
		
	}
	
	// Update is called once per frame
	void Update () {
		if(currentExp >= toLevelUp[currentLevel]) {
			//currentLevel++;
			LevelUp();
		}
	}


	public void AddExp(int expToAdd) {
		currentExp += expToAdd;
	}

	public void LevelUp(){
		currentLevel++;
		currentHp = HPLevels[currentLevel];

		thePlayerHealth.playerMaxHealth = currentHp;
		thePlayerHealth.playerCurrentHealth += currentHp - HPLevels[currentLevel -1];



		currentAttack = attackLevels[currentLevel];
		currentDefence = defenceLevels[currentLevel];
	}



}
