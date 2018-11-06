using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBaseMov3D : MonoBehaviour {

    Rigidbody rigBod;
    Vector3 movement;
    Vector3 respawnPos;

    public float speed = 5f;
    public float angSpeed = 25f;
    public float jumpForce = 10f;

	// Use this for initialization
	void Start () {
        rigBod = GetComponent<Rigidbody>();
        respawnPos = transform.position;
	}

	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            rigBod.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
        }
	}

	void FixedUpdate () {
        movement = transform.forward * Input.GetAxis("Vertical");
        rigBod.MovePosition(rigBod.position + (movement * speed * Time.fixedDeltaTime));
        Quaternion rotation = Quaternion.Euler(Vector3.up * Input.GetAxis("Horizontal") * angSpeed * Time.fixedDeltaTime);
        rigBod.MoveRotation(rotation * rigBod.rotation);
	}

    void Respawn () {
        rigBod.velocity = Vector3.zero;
        rigBod.MovePosition(respawnPos);
    }

	void OnTriggerExit (Collider other) {
        if (other.CompareTag("PlayArea")) {
            Respawn();
        }
	}
	void OnDrawGizmos () {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, transform.forward);
	}
}
