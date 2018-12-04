
using UnityEngine;

public class Gun : MonoBehaviour {

	public float damage = 10f;
	public float range = 100f;
	public float impactForce = 100f;
	public float fireRate = 15f;
	
	public Camera fpsCam;
	public ParticleSystem muzzleFlash;
	public GameObject impactFX;

	private float nextTimetoFire = 0f;

	// Update is called once per frame
	void Update () {
		
		if (Input.GetButton("Fire1") && Time.time >= nextTimetoFire) {

			nextTimetoFire = Time.time + 1f/fireRate;
			Shoot();

		}

	}


	void Shoot() {

		muzzleFlash.Play();

		RaycastHit hit;



		if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range) ) {
			
			Debug.Log(hit.transform.name);

			Target target = hit.transform.GetComponent<Target>();

			if (target != null) {
				target.TakeDamage(damage);
			}

			if (hit.rigidbody != null) {
				hit.rigidbody.AddForce(-hit.normal * impactForce);
			}

			GameObject impactGO = Instantiate(impactFX, hit.point, Quaternion.LookRotation(hit.normal));
			Destroy(impactGO, 2f);
		}
		

	}


}
 