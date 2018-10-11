using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour {

    public float speed = 2f;

	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
	}

	private void OnTriggerEnter2D (Collider2D other) {
        if (other.CompareTag("SraK")) {
            other.GetComponent<DestroyableObject>().DestroySelf();
            Destroy(gameObject);
        } else if (other.CompareTag("walls")) {
        	Destroy(gameObject);
        }
	}
}

   
