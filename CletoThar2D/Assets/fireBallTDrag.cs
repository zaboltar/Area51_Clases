using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireBallTDrag : MonoBehaviour {

    
    public float speed;
    private Transform playerPos;
    public Animator anim;
    public Vector3 lastPos;

    
    // Use this for initialization
    void Start() {
        
        speed = 3f;
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;

        // Add + 1 to player's last known position so bullet appears to float above ground.
        lastPos = new Vector3(playerPos.position.x, playerPos.position.y, playerPos.position.z);

        // Aim bullet in player's direction.
        transform.LookAt(lastPos);


    }

    // Update is called once per frame
    void Update() {
        // Move the projectile forward towards the player's last known direction;
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    private void FixedUpdate()
    {
        

        /*if (Vector3.Distance(transform.position, lastPos) < 0.2f)
        {
            Destroy(gameObject);
        }*/
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }


}
