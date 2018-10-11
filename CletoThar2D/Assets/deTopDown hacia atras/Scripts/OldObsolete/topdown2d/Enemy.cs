using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {

	public float speed;
	private Transform playerPos;
	private Playertpdown2d player;
	public GameObject pfx;

		
	void Start(){
		player = GameObject.FindGameObjectWithTag("Player2").GetComponent<Playertpdown2d>();
		speed = 6f;
		playerPos = GameObject.FindGameObjectWithTag("Player2").transform;
	}


	void Update(){

		transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);
		
	}


	void OnTriggerEnter2D(Collider2D other){
		
		if (other.CompareTag("Player2")){
			Instantiate(pfx, transform.position, Quaternion.identity);
			player.health--;
			Debug.Log(player.health);
			Destroy(gameObject);
		}
	
		if (other.CompareTag("bolt")){
			Instantiate(pfx, transform.position, Quaternion.identity);
			Destroy(other.gameObject);
			Destroy(gameObject);
			
		}




	}









}
