    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//heredamos los structs de este namespace
using EntityData.StructLib;

public class CharacterBaseMov3D : MonoBehaviour {



    Rigidbody rigBod;
    Vector3 movement;

    CharTransformData respawnData;


    public float speed = 5f;
    public float angSpeed = 25f;
    public float jumpForce = 10f;

    public bool grounded = false;
    List<Collider> groundCollection;

	// Use this for initialization
	void Start () {
		groundCollection = new List<Collider>();

        rigBod = GetComponent<Rigidbody>();
        respawnData.position = transform.position;
        respawnData.rotation = transform.rotation;
	}

	void Update () {
        if (grounded && Input.GetKeyDown(KeyCode.Space)) {
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
        Reposition(respawnData);
        CamBehaviour.main.Reposition(respawnData.position + CamBehaviour.main.data.followDistance);
    }

    public void Reposition(CharTransformData transformData) {
        rigBod.MovePosition(respawnData.position);
        rigBod.MoveRotation(respawnData.rotation);
    }

    public void SetRespawn (CharTransformData transformData) {
        respawnData = transformData;
    }

    /*float GetMaxInclination () {
        groundCollection.Sort((x, y) => y.incNormalized.CompareTo(x.incNormalized));
        return groundCollection.Count != 0 ? groundCollection[0].incNormalized : 0;
    }*/


	void OnCollisionStay (Collision collision) {
        if (!groundCollection.Contains(collision.collider)) {
            foreach (ContactPoint contact in collision.contacts) {
                Debug.DrawRay(contact.point, contact.normal, Color.yellow, 0.25f);
                float inclination;
                if ((inclination = Vector3.Dot(contact.normal, Vector3.up)) > 0.85f) {
                    grounded = true;
                    groundCollection.Add(collision.collider);
                    break;
                }
            }
        }
    }
    void OnCollisionExit(Collision collision) {
        if (groundCollection.Contains(collision.collider)) {
            groundCollection.Remove(collision.collider);
        }
        if (groundCollection.Count == 0) {
            grounded = false;
        }
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
