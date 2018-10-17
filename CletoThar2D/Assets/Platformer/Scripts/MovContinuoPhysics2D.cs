using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utilities2D;

[RequireComponent(typeof(Rigidbody2D))]
public class MovContinuoPhysics2D : MonoBehaviour {

    public float speed;
    public List<AxisPair> axes;
    public Rigidbody2D rb2D;
    public Animator animator;


	void Reset()
	{
        rb2D = GetComponent<Rigidbody2D>();
        rb2D.gravityScale = 0;
        rb2D.constraints = RigidbodyConstraints2D.FreezeRotation;
	}

	void FixedUpdate () {
        Vector3 movement = Vector3.zero;
        for (int i = 0; i < axes.Count; i++)
        {
            if(Input.GetKey (axes[i].keyCode) ) {
                movement += axes[i].direction;
            }
        }

        /* ESTA PARTE LA USAMOS TEMPORALMENTE PARA "FLIPEAR" SIMPLEMENTE UN SPRITE
        movement = movement.normalized * speed * Time.fixedDeltaTime;
        if (movement.x > 0) { GetComponent<SpriteRenderer>().flipX = false; }
        else if (movement.x < 0 ) { GetComponent<SpriteRenderer>().flipX = true;}
          rb2D.MovePosition(transform.position + movement); */

          if (movement != Vector3.zero) {
            animator.SetBool ("Moving", true);
            animator.SetFloat ("Horizontal", movement.x);
            animator.SetFloat ("Vertical", movement.y);
          } else {
            animator.SetBool ("Moving", false);
          }

        movement = movement.normalized * speed * Time.fixedDeltaTime;
        rb2D.MovePosition(transform.position + movement);

    }
}
