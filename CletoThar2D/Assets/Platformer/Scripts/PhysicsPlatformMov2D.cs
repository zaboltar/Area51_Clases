using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utilities2D;

[RequireComponent(typeof(Rigidbody2D))]
public class PhysicsPlatformMov2D : MonoBehaviour {

    public Vector2 speed;
    public List<AxisPair> axes;
    public Rigidbody2D rb2D;
    public float gravity = 8;
    public bool grounded;
    public Animator animator; //anim test

    Vector3 movement;

    void Reset () {
        rb2D = GetComponent<Rigidbody2D> ();
        rb2D.gravityScale = 0;
        rb2D.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        movement = Vector3.zero;
        for (int i = 0; i < axes.Count; i++) {
            if (Input.GetKey (axes[i].keyCode)) {
                movement += axes[i].direction;
            }
        }
            //test
           if (movement != Vector3.zero) {
            animator.SetBool ("Moving", true);
            animator.SetFloat ("Horizontal", movement.x);
            animator.SetFloat ("Vertical", movement.y);
          } else {
            animator.SetBool ("Moving", false);
          }
          //anim test

          if (Input.GetKeyDown(KeyCode.Q)) {
          animator.SetBool ("Att1", true);
          
        } else if (Input.GetKeyUp(KeyCode.Q)) {
          animator.SetBool ("Att1", false);
	       }

           if (Input.GetKeyDown(KeyCode.E)) {
          animator.SetBool ("Att2", true);
          
        } else if (Input.GetKeyUp(KeyCode.E)) {
          animator.SetBool ("Att2", false);
           }

           if (Input.GetKeyDown(KeyCode.R)) {
          animator.SetBool ("Att3", true);
          
        } else if (Input.GetKeyUp(KeyCode.R)) {
          animator.SetBool ("Att3", false);
           }

           if (Input.GetKeyDown(KeyCode.T)) {
          animator.SetBool ("Att4", true);
          
        } else if (Input.GetKeyUp(KeyCode.T)) {
          animator.SetBool ("Att4", false);
           }
           if (Input.GetKeyDown(KeyCode.Y)) {
          animator.SetBool ("Att5", true);
          
        } else if (Input.GetKeyUp(KeyCode.Y)) {
          animator.SetBool ("Att5", false);
           }
 }
    

    void FixedUpdate () {
        if (!grounded) {
            speed.y -= gravity * Time.fixedDeltaTime;
        }

        RaycastHit2D hit2D = Physics2D.Raycast (transform.position, Vector3.down, 0.55f);
        if (hit2D) {
           // Debug.Log (hit2D.collider.name);
            speed.y = 0;
            grounded = true;
        } else {
            grounded = false;
        }

        movement = movement.normalized * speed.x * Time.fixedDeltaTime;
        movement.y = speed.y * Time.fixedDeltaTime;
        rb2D.MovePosition (transform.position + movement);
    }

    void OnDrawGizmos () {
        Gizmos.color = Color.red;
        Gizmos.DrawRay (transform.position, Vector3.down);
    }
}
