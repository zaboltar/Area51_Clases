 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//heredamos los structs de este namespace
using EntityData.StructLib;
using VectorLib;

public class CharacterBaseMov3D : MonoBehaviour {

    // revisar esto, imposible de seguir en tiempo real -.-

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

        if (rigBod.velocity.x != 0 || rigBod.velocity.z != 0) {
            Vector3 temp = rigBod.velocity;
            temp.x = Mathf.MoveTowards(temp.x, 0, 2f * Time.deltaTime);
            temp.z = Mathf.MoveTowards(temp.z, 0, 2f * Time.deltaTime);
            rigBod.velocity = temp;
            Debug.Log(rigBod.velocity);
        } //epsilon es un infinito a zero float.Epsilon
	}

	void FixedUpdate () {
        movement = transform.forward * Input.GetAxis("Vertical");
        rigBod.MovePosition(rigBod.position + (movement * speed * Time.fixedDeltaTime));
        Quaternion rotation = Quaternion.Euler(Vector3.up * Input.GetAxis("Horizontal") * angSpeed * Time.fixedDeltaTime);
  
        // Quaternion rotation = Quaternion.Euler(Vector3.up * Input.GetAxis("Horizontal") * angSpeed * Time.fixedDeltaTime);
            // aca podria cambiarse para variar la vision de camara, reemplazar "horiz" x Mouse X
        // Quaternion rotation = Quaternion.Euler(Vector3.up * Input.GetAxis("Mouse X") * angSpeed * Time.fixedDeltaTime);
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

	void OnCollisionEnter(Collision collision) {
        /*if (collision.collider.CompareTag("MovingPlatform")) {
            transform.SetParent(collision.transform); 
            //emparenta el player a la plataforma, hace falta desvincularlo!
            // se moviò esta parte a otro lado
        }*/
	}

	void OnCollisionStay (Collision collision) {
        if (!groundCollection.Contains(collision.collider)) {
            foreach (ContactPoint contact in collision.contacts) {
                Debug.DrawRay(contact.point, contact.normal, Color.yellow, 0.25f);
                float inclination;
                if ((inclination = Vector3.Dot(contact.normal, Vector3.up)) > 0.85f)
                {
                    grounded = true;
                    groundCollection.Add(collision.collider);
                }
                if (collision.collider.CompareTag("MovingPlatform"))
                {
                    transform.SetParent(collision.transform);
                    break;
                }
            }
        }
    }

	void OnTriggerEnter(Collider other)
	{
        if (other.CompareTag("Activator")) {
            other.GetComponent<Activator>();
            currentActivator = other.
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
        }


    }



	void OnTriggerExit (Collider other) {
        if (other.CompareTag("PlayArea")) {
            Respawn();
        } else if (other)
	}
	void OnDrawGizmos () {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, transform.forward);
	}
}




// para saltos, hay que usar un blend tree, la condicion que lo activa es la negacion del isGrounded. Lo que se chequea es un valor
// normalizado del velocity (un float), especificamente del Y. Una animacion es para elevaciòn, otra para caidas, eso evita los problemas de salto 
// "estàtico"... Debe implementarse en algun update o mejor, fixed update. Meter la mano al velocity es delicado y es mejor usarlo solo en 
// situaciones como para respawnear. Habria que asignar un booleano fijo y chequearlo constantemente desde el update...o algo asì! 