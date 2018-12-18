using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handgunPickUp : MonoBehaviour {

	public GameObject realHGun;
	public GameObject fakeHGun;
	public AudioSource	hGunPickFX;

	void OnTriggerEnter ( Collider other) {
		realHGun.SetActive(true);
		fakeHGun.SetActive(false);
		hGunPickFX.Play();
		this.GetComponent<BoxCollider>().enabled = false;
	}

}
