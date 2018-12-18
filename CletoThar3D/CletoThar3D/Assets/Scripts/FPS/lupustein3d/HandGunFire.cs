using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGunFire : MonoBehaviour {

	public GameObject theGun;
    public GameObject muzzleFlash;
    public AudioSource gunFire;
    public bool isFiring = false;
	
	


	void Update () {
			if (Input.GetButtonDown("Fire1")) {
            	if (isFiring == false) {
                StartCoroutine(FiringHandgun());
            	}
            
        	}
	}

	 IEnumerator FiringHandgun() {
        isFiring = true;
        theGun.GetComponent<Animator>().Play("hgunfire");
        muzzleFlash.SetActive(true);
        gunFire.Play();
        yield return new WaitForSeconds(0.05f);
        muzzleFlash.SetActive(false);
        yield return new WaitForSeconds(0.25f);
        theGun.GetComponent<Animator>().Play("gunDefault");
        isFiring = false;
    }

}
