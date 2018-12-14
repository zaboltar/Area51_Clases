using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EntityData.StructLib;



public class Checkpoint : MonoBehaviour {

    public CharTransformData pointData;

	// Use this for initialization
	void Start () {
        pointData.position += transform.position;
        pointData.rotation = transform.rotation;
	}
	

	void OnTriggerEnter (Collider other) {
        if (other.CompareTag("Player")) {
           // other.GetComponent<CharacterBaseMov3D>().SetRespawn(pointData);
            other.GetComponent<Try2Adapt>().SetRespawn(pointData);
        }
	}
}
