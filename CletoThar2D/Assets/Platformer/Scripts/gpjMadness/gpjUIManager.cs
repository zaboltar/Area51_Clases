using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gpjUIManager : MonoBehaviour {

	public Slider healthBar;
	public Text healthText;
	public Text levelText;
	public gpjHealthManager playerHealth;
	private gpjPlayerStats thePs;

	// Use this for initialization
	void Start () {
		thePs = GetComponent<gpjPlayerStats>();
	}
	
	// Update is called once per frame
	void Update () {
		healthBar.maxValue = playerHealth.playerMaxHealth;
		healthBar.value = playerHealth.playerCurrentHealth;
		healthText.text = "HP: " + playerHealth.playerCurrentHealth + "/" + playerHealth.playerMaxHealth;
		levelText.text = "Lvl: " + thePs.currentLevel;
	}
}
