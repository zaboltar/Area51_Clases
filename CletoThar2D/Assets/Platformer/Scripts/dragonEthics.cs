using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragonEthics : MonoBehaviour {

    public float distance = 1;
    private float currentDistance;
    public Animator animator;

    public float speed = 1;
    public Vector2 direction;
    public Vector3 movement { get { return direction * speed * Time.deltaTime; } }
   // public int dinoHealth = 3;
   // public GameObject dinoBlood;

    void Update()
    {


        currentDistance += movement.magnitude;
        if (currentDistance >= distance)
        {
            SpriteRenderer rend = GetComponent<SpriteRenderer>();

            rend.flipX = !rend.flipX;
            direction *= -1;

            currentDistance = 0;

        }

        
    }

    private void FixedUpdate()
    {
        transform.Translate(movement);

    }


    void OnTriggerEnter2D(Collider2D other)
    {
       /*
        if (other.tag == "bolt")

        {
            Destroy(other.gameObject);
            dinoHealth--;

            GameObject dinoBloodSplash = Instantiate(dinoBlood, transform.position, Quaternion.identity);
            Destroy(dinoBloodSplash, 0.3f);


            if (dinoHealth <= 0)
            {
                Destroy(gameObject);
            }

        }
                
*/
    }




}
