using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spear : MonoBehaviour {

	private Vector2 target;
	public float speed;


	void Start () {
		target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        SpriteRenderer rend = GetComponent<SpriteRenderer>();
        if (target.x > transform.position.x) {
            rend.flipX = false;
        } else {
            rend.flipX = true;
        }
    }
	
	
	void Update () {
		transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
	    
		if (Vector2.Distance(transform.position,target) < 0.2f) {
			Destroy(gameObject);
		}



	}

    /*private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("dinoEnemy"))
        {
            other.GetComponent<DestroyableObject>().DestroySelf();
            Destroy(gameObject);
        }
        else if (other.CompareTag("walls"))
        {
            Destroy(gameObject);
        }
    }*/
}
