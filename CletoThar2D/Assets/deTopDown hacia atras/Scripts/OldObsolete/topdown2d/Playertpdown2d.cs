using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Playertpdown2d : MonoBehaviour {

	public float speed;
	public int health = 10;
	public Text healthDisplay;
	private Rigidbody2D rb;

	private Vector2 moveVelocity;

	void Start() {
		speed = 10f;
		rb = GetComponent<Rigidbody2D>();
	}


	void Update() {

		healthDisplay.text = "Health = " + health;

		if(health <= 0){
			 UnityEngine.SceneManagement.SceneManager.LoadScene(5);	
		} 

		Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical") );
		moveVelocity = moveInput.normalized * speed;
	}


	void FixedUpdate(){

			rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
	}









}

