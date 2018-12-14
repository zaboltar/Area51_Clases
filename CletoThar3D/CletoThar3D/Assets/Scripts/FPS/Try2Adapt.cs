using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EntityData.StructLib;
using VectorLib;

public class Try2Adapt : MonoBehaviour {

	Rigidbody rigBod;
    Vector3 movement;
    CharTransformData respawnData;
    public float speed = 5f;
    public float angSpeed = 25f;
    public float jumpForce = 10f;
    public bool grounded = false;
    public bool inputEnabled = true;
    List<Collider> groundCollection;
    Activator currentActivator;
    //Animator playerAnimator;

	
	void Start () {
		groundCollection = new List<Collider>();

        rigBod = GetComponent<Rigidbody>();

        //playerAnimator = GetComponent<Animator>();
        respawnData.position = transform.position;
        respawnData.rotation = transform.rotation;
        if (!GameControl.instance.currentPlayer || GameControl.instance.currentPlayer != this) {
            GameControl.instance.currentPlayer = this;
        }
	}

	void Update () {

        if (inputEnabled) {
            if (grounded && Input.GetKeyDown(KeyCode.Space))
            {
                // set velocity Y to zero for consistent jump height
               // por ahora lo hace pController rigBod.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
            }
            else if (currentActivator && Input.GetKeyDown(KeyCode.E))
            {
                currentActivator.Use();
               // playerAnimator.SetTrigger("Pickup");
                inputEnabled = false;
            }
        }


        /*if (rigBod.velocity.x != 0 || rigBod.velocity.z != 0) {
            Vector3 temp = rigBod.velocity;
            temp.x = Mathf.MoveTowards(temp.x, 0, 2f * Time.deltaTime);
            temp.z = Mathf.MoveTowards(temp.z, 0, 2f * Time.deltaTime);
            rigBod.velocity = temp;
            Debug.Log(rigBod.velocity);
        } //epsilon es un infinito a zero float.Epsilon*/
	}

	void FixedUpdate () {

        float verticalMagnitude = 0, angularMagnitude = 0;

       /* if (inputEnabled) {
             verticalMagnitude = Input.GetAxis("Vertical");
             angularMagnitude = Input.GetAxis("Horizontal");
        }*/


        movement = transform.forward * verticalMagnitude;
       // playerAnimator.SetFloat("MoveSpeed", verticalMagnitude);
       // rigBod.MovePosition(rigBod.position + (movement * speed * Time.fixedDeltaTime));
      //  Quaternion rotation = Quaternion.Euler(Vector3.up * angularMagnitude * angSpeed * Time.fixedDeltaTime);
        // aca podria cambiarse para variar la vision de camara, reemplazar "horiz" x Mouse X
        // Quaternion rotation = Quaternion.Euler(Vector3.up * Input.GetAxis("Mouse X") * angSpeed * Time.fixedDeltaTime);
      //rigBod.MoveRotation(rotation * rigBod.rotation);

	}

    public void Respawn () {
        
        rigBod.velocity = Vector3.zero;
        Reposition(respawnData);
       // CamBehaviour.main.Reposition(respawnData.position + CamBehaviour.main.data.followDistance);
    }

    public void EnableInput() {
        inputEnabled = true;
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
                    //playerAnimator.SetBool("Grounded", grounded);
                    groundCollection.Add(collision.collider);
                    if (collision.collider.CompareTag("MovingPlatform")) {
                        transform.SetParent(collision.transform);
                    }
                    break;
                }
            }
        }
    }

	
	void OnCollisionExit(Collision collision) {
        if (groundCollection.Contains(collision.collider)) {
            groundCollection.Remove(collision.collider);
            if  (collision.collider.CompareTag("MovingPlatform")) {
                transform.SetParent(null);
                Vector3 exitMomentum = collision.collider.GetComponent<PlatformBehaviour3D>().currentMomentum;
                exitMomentum = VectorExt.OneByeOneProduct(exitMomentum, VectorExt.zeroY);
                rigBod.AddForce(exitMomentum, ForceMode.VelocityChange);
            } //lookAtThis

        }

        if (groundCollection.Count == 0) {
            grounded = false;
          //  playerAnimator.SetBool("Grounded", grounded);
        }

    }

    void OnTriggerEnter(Collider other)
	{
        if (other.CompareTag("Activator")) {
            other.GetComponent<Activator>();
            currentActivator = other.GetComponent<Activator>();
        }	else if (other.CompareTag("LevelGoal")) {
            transform.SetParent(other.transform);
            transform.localPosition = VectorExt.OneByeOneProduct(transform.localPosition, Vector3.up);
            inputEnabled = false;
            int goalIndex = other.GetComponent<LevelSelectorData>().levelIndex;
            GameControl.instance.StartLevelChangeProcess(goalIndex);
        }


	}



	void OnTriggerExit (Collider other) {
        if (other.CompareTag("PlayArea")) {
            inputEnabled = false;
            //Respawn();
            GameControl.instance.StartRespawnProcess();
        } else if (other.CompareTag("Activator")) {
            currentActivator = null;
        }
	}
	
	void OnDrawGizmos () {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position + Vector3.up, transform.forward);
	}
}



