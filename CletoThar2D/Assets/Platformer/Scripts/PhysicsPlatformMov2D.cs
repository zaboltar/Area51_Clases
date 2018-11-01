using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utilities2D;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
public class PhysicsPlatformMov2D : MonoBehaviour {

    public Vector2 speed;
    public Animator animator;
    public List<AxisPair> axes;
    public Rigidbody2D rb2D;
    public Collider2D col2D; 
    public float gravity = 8f;
    public float jumpForce = 5f;
    public bool grounded;

    public Collider2D attackOrigin;
    const float attackDistance = 0.8f;
    bool isAttack;
 
    Vector3 movement;
    float lastDir;
    Vector2 distanceLeft;
    Vector2 distanceRight;
    Vector2 pointCenter{ get { return rb2D.position + distanceCenter; }}
    Vector2 distanceCenter;
    const float margin = 0.2f;
    const float minDistance = 0.1f; //0.05 || 0.5f
    public Vector2 pointLeft { get { return rb2D.position + distanceLeft; }}
    public Vector2 pointRight { get { return rb2D.position + distanceRight; }}
    //public int playerHealth = 3;
   // public Text HPText;
    public GameObject blood;
   //public GameObject spearWeapon;

    
    void Reset () {
        rb2D = GetComponent<Rigidbody2D> ();
        rb2D.gravityScale = 0;
        rb2D.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

	void Start () {
        //HPText.text = "Health: " + playerHealth;
        
        distanceLeft.x = -(col2D.bounds.extents.x - margin);
        distanceLeft.y = -col2D.bounds.extents.y;
        distanceRight.x = col2D.bounds.extents.x - margin;
        distanceRight.y = -col2D.bounds.extents.y;
        distanceCenter.y = -col2D.bounds.extents.y;

	}
	
	void Update () {
        movement = Vector3.zero;
        for (int i = 0; i < axes.Count; i++) {
            if (Input.GetKey (axes[i].keyCode)) {
                movement += axes[i].direction;
            }
        }
        //anim test moved to fixedupdate

         // also attacks

          // if (Input.GetKeyDown(KeyCode.T)) {    throw=click
          //animator.SetBool ("Att4", true);
          
        //} else if (Input.GetKeyUp(KeyCode.T)) {
          //animator.SetBool ("Att4", false);


        //   } else if (Input.GetKeyDown(KeyCode.Y)) {   salto=spacebar
       //  animator.SetBool ("Att5", true);               pero no funciona aun
          
       // } else if (Input.GetKeyUp(KeyCode.Y)) {
         // animator.SetBool ("Att5", false);}

        if (grounded && Input.GetKeyDown(KeyCode.Space)) {
            
           //ESTO ESTA BIEN AQUI?!
           animator.SetTrigger("Jump");
           speed.y = jumpForce;
        } 



 }
    

    void FixedUpdate () {
        if (!grounded) {
        	 
        	
            speed.y -= gravity * Time.fixedDeltaTime;
            
        } 

        GroundCheck();

        SpriteRenderer rend = GetComponent<SpriteRenderer>();
        if (movement.x > 0 && rend.flipX) {
         rend.flipX = false; 
         lastDir =1f;
        // spearWeapon.GetComponent<SpriteRenderer>().flipX = false;//tmb lo intente con box collider2d: nada

       } else if (movement.x < 0 && !rend.flipX) { 
          rend.flipX = true;
          lastDir =-1f;
          //spearWeapon.GetComponent<SpriteRenderer>().flipX = true;
          }

        // ACA FALTA IMPLEMENTAR: el giro del spear a la par que del player.renderer
            //ahora paso esta sección que antes estaba en el update
              //test
           if (movement != Vector3.zero) {
            animator.SetBool ("Moving", true);
            animator.SetFloat ("Horizontal", movement.x);
            animator.SetFloat ("Vertical", movement.y);
          } else {
            animator.SetBool ("Moving", false);
          }
          //anim test + //revolution of new box collider

           if (grounded && Input.GetKeyDown(KeyCode.Q)) {
          animator.SetTrigger("Attack0");
          Vector3 temp = attackOrigin.transform.localPosition;
          temp.x = attackDistance * lastDir;
          attackOrigin.transform.localPosition = temp;
          attackOrigin.enabled = true;
          isAttack = true;
          } 

            if (grounded && Input.GetKeyDown(KeyCode.W)) {
          animator.SetTrigger("Attack1");
          Vector3 temp = attackOrigin.transform.localPosition;
          temp.x = attackDistance * lastDir;
          attackOrigin.transform.localPosition = temp;
          attackOrigin.enabled = true;
          isAttack = true;
          } 

            if (grounded && Input.GetKeyDown(KeyCode.E)) {
          animator.SetTrigger("Attack2");
          Vector3 temp = attackOrigin.transform.localPosition;
          temp.x = attackDistance * lastDir;
          attackOrigin.transform.localPosition = temp;
          attackOrigin.enabled = true;
          isAttack = true;
          } 





        if (isAttack) { movement.x =0;}
        movement = movement.normalized * speed.x * Time.fixedDeltaTime;
        movement.y = speed.y * Time.fixedDeltaTime;
        rb2D.MovePosition (transform.position + movement);
    }

    void OnDrawGizmos () {
        Gizmos.color = Color.red;
        Gizmos.DrawRay (pointLeft, Vector3.down * minDistance);
        Gizmos.DrawRay(pointRight, Vector3.down * minDistance); //0.1||0.5f
    }

    void GroundCheck()
    {
        Vector2[] points = { pointLeft, pointCenter, pointRight };
        RaycastHit2D[] hits2D = new RaycastHit2D[points.Length];
        grounded = false;

        for (int i = 0; i < points.Length; i++)
        {
            hits2D[i] = Physics2D.Raycast(points[i], Vector3.down, minDistance);

            if (hits2D[i])
            {
               // Debug.Log (hits2D[i].collider.name);
              PlatformBehaviour behaviour = hits2D[i].collider.GetComponent<PlatformBehaviour>();
                if (speed.y < 0){
                    transform.position = (transform.position + (Vector3.down * minDistance));
                    // Debug.Log algo
                    speed.y = 0;
                    if (behaviour != null) { behaviour.OnPlatformStep(gameObject);}
                }
                grounded = true;
                break;
            }
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("deathzone")) {
                       
            UnityEngine.SceneManagement.SceneManager.LoadScene(8);  
             }


        if ( other.CompareTag("dinoEnemy"))
        {
            //playerHealth--;
           // other.GetComponent<Animator>().SetBool("isAttacking", true);
            Instantiate(blood, transform.position, Quaternion.identity);
          
            
        }

        /*if (other.CompareTag("fireball"))
        {
            playerHealth--;
           
            Instantiate(blood, transform.position, Quaternion.identity);
            HPText.text = "Health: " + playerHealth;
            if (playerHealth <= 0)
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(8);
            }


        }*/


    }

    void OnAttackEnd(){
      attackOrigin.enabled=false;
      isAttack = false;
    }

}
