using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gpjHealthManager : MonoBehaviour {


	public int playerMaxHealth;
	public int playerCurrentHealth;

	private bool flashActive;
	public float flashLength;
	private float flashCounter;

	private SpriteRenderer playerSprite;

	public GameObject blood;
	
	// Use this for initialization
	void Start () {

		playerCurrentHealth = playerMaxHealth;

		playerSprite = GetComponent<SpriteRenderer>();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (playerCurrentHealth <= 0) {
			UnityEngine.SceneManagement.SceneManager.LoadScene(8);  
		}

		if (flashActive) {

			if (flashCounter > flashLength * .66f){
				playerSprite.color = new Color (playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 0f);
				} else if (flashCounter > flashLength * .33f){
					playerSprite.color = new Color (playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 1f);
				} else if (flashCounter > 0f) {
					playerSprite.color = new Color (playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 0f);
				
				} else {

				playerSprite.color = new Color (playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 1f);
				flashActive = false;
			}


			flashCounter -= Time.deltaTime;
		}




	}

	public void HurtPlayer(int damageToGive){
		playerCurrentHealth = playerCurrentHealth - damageToGive;

		flashActive = true;
		flashCounter = flashLength;
		Instantiate(blood, transform.position, Quaternion.identity);


	}

	public void SetMaxHealth(){
		playerCurrentHealth = playerMaxHealth;
	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.tag == "health"){
			playerCurrentHealth += 5;
			Destroy(other.gameObject);
		}
	}


}
