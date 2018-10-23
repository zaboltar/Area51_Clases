using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utilities2D;

[RequireComponent(typeof(Rigidbody2D))]
public class adaptsraK : MonoBehaviour {

    public float speed;
    public List<AxisPair> axes;
    public Rigidbody2D rb2D;
    public Animator animator;
    private int collectSpeedTreasure = 0;
    public GameObject bulletPrefab;


	void Reset()
	{
        rb2D = GetComponent<Rigidbody2D>();
        rb2D.gravityScale = 0;
        rb2D.constraints = RigidbodyConstraints2D.FreezeRotation;
	}

	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(bulletPrefab, transform.position + Vector3.up, transform.rotation);
        }
	}

	void FixedUpdate () {
        Vector3 movement = Vector3.zero;
        for (int i = 0; i < axes.Count; i++)
        {
            if(Input.GetKey (axes[i].keyCode) && !FindObstacle(axes[i].direction) ) {
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

    void OnTriggerEnter2D(Collider2D other)
	{
        if (other.CompareTag("SraK")) {
            Debug.Log("Fujimorizado");
            
            GameControl.instance.RestartLevel();
            //UnityEngine.SceneManagement.SceneManager.LoadScene(8);  

        }

         if (other.CompareTag("Goal")) {
            Debug.Log("Has alcanzado la meta");

                     
            } else if (other.CompareTag("Collectable")) {
            	other.GetComponent<CollectableObject>().Collect();
                collectSpeedTreasure++;
                speed++;
            }
	}


  bool FindObstacle(Vector3 direction) {
        RaycastHit2D[] hits2D = Physics2D.RaycastAll (transform.position, direction, 0.5f);
        Debug.DrawRay (transform.position, direction / 2, Color.blue, 2);

        foreach (RaycastHit2D hit2D in hits2D) {
        	if (hit2D.collider.CompareTag("walls")) {
        	return true;
       		 }
        }
    return false;
    } 


}
