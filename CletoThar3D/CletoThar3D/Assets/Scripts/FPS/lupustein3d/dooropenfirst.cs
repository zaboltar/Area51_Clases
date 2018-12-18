using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dooropenfirst : MonoBehaviour {

	   public GameObject theDoor;
	   public AudioSource doorFX;

    void OnTriggerEnter(Collider other)
    {
    	doorFX.Play();
        theDoor.GetComponent<Animator>().Play("doorOpens");
        this.GetComponent<BoxCollider>().enabled = false;
        StartCoroutine(CloseDoor());
    }

    IEnumerator CloseDoor() {
    	yield return new WaitForSeconds(5);
    	doorFX.Play();
    	theDoor.GetComponent<Animator>().Play("doorCloses");
    	this.GetComponent<BoxCollider>().enabled = true;

    }


}

//Jimmy Vegas Unity Tutorial
//This script will open your door