using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlGen : MonoBehaviour {

	public GameObject platformPrefab;

	public int numberOfPlatforms = 200;
	public float lvlWidth = 12f;
	public float minY = .2f;
	public float maxY = 1.5f;

	// Use this for initialization
	void Start () {

		Vector3 spawnPosition = new Vector3();
		
		for (int i=0; i < numberOfPlatforms; i++){
		
		spawnPosition.y += Random.Range(minY, maxY);
		spawnPosition.x = Random.Range(-lvlWidth, lvlWidth);
		Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
