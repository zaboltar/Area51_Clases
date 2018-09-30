using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject enemy;
	public Transform[] spawnSpots;
	private float timeBtwSpawns;
	public float startTimeBtwSpwns;

	void Start(){
		timeBtwSpawns = startTimeBtwSpwns;
	}

	void Update(){
		if (timeBtwSpawns <= 0){
			int randPos = Random.Range(0, spawnSpots.Length);
			Instantiate(enemy, spawnSpots[randPos].position, Quaternion.identity);
			timeBtwSpawns = startTimeBtwSpwns;
		} else {
			timeBtwSpawns -= Time.deltaTime;
		}
	}








}
