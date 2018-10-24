using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

// gamesplusjames - unity tutorial #11 making enemies


public class BlueDragGamPlusJames : MonoBehaviour {

	public float moveSpeed;

	private Rigidbody2D myRB;

	private bool moving;

	public float timeBtwMove;
	private float timeBtwMoveCounter;
	public float timeToMove;
	private float timeToMoveCounter;
	private Vector3 moveDirection; 
	public float waitToReload;
	private bool reloading;
	private GameObject theplayer;

	// Use this for initialization
	void Start () {

		myRB = GetComponent<Rigidbody2D>();

		//timeBtwMoveCounter = timeBtwMove;
		//timeToMoveCounter = timeToMove;

		timeBtwMoveCounter = Random.Range(timeBtwMove * 0.75f, timeBtwMove * 1.25f);
		timeToMoveCounter = Random.Range(timeToMove * 0.75f, timeBtwMove* 1.25f);

	}
	
	// Update is called once per frame
	void Update () {


		if (moving){

			timeToMoveCounter -= Time.deltaTime;
			myRB.velocity = moveDirection;

			if (timeToMoveCounter < 0f){
				moving = false;
				//timeBtwMoveCounter = timeBtwMove;
				timeBtwMoveCounter = Random.Range(timeBtwMove * 0.75f, timeBtwMove * 1.25f);
			}


			} else {
				timeBtwMoveCounter -= Time.deltaTime;
				myRB.velocity = Vector2.zero;

				if (timeBtwMoveCounter < 0f){
					moving = true;
					//timeToMoveCounter = timeToMove;
					timeToMoveCounter = Random.Range(timeToMove * 0.75f, timeBtwMove* 1.25f);

					moveDirection = new Vector3(Random.Range(-1f, 1f)* moveSpeed, Random.Range(-1f, 1f) * moveSpeed, 0f);
				}
			}

			if (reloading) {
				waitToReload -= Time.deltaTime;
				if(waitToReload < 0f) {
					// deprecado Application.LoadLevel(Application.loadedLevel);
					//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
					//SceneManager.LoadScene(SceneManager.GetActiveScene().name);﻿
					// ninguna funciona PERO NO IMPORTA >:)

					theplayer.SetActive(true);
				}
			}

	}

	void OnCollisionEnter2D(Collision2D other) {
		/*if (other.gameObject.name == "Player") {
			//Destroy(gameObject.other);

			other.gameObject.SetActive(false);
			
			theplayer = other.gameObject;
		}*/
	reloading = true;
}




}
