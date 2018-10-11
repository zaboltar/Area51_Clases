using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//esto afecta a la clase siguiente [], en este caso EntityPhysics2D, debe estar inmediatamente contigua para la afecciòn
// llamamos a la clase Type de System para adquirir informaciòn
// para trabajar esto, debemos trasladar el tipo a una variable
// para no crear instancia de elemento, usamos snipet typeof()
// type no es una clase != typeof .... tiene informaciòn del tipo
// 
[RequireComponent(typeof(Rigidbody2D))]

public class EntityPhysics2D : MonoBehaviour {


    public float speed = 1;
    public Vector2 direction;
    public Vector3 movement { get { return direction * speed * Time.fixedDeltaTime; } }

	public Rigidbody2D rb2D;

    protected virtual void Reset()
    {
        rb2D =  GetComponent<Rigidbody2D>();
        rb2D.gravityScale = 0;
        rb2D.constraints = RigidbodyConstraints2D.FreezeRotation;

    }

    protected virtual void FixedUpdate()
    {
        rb2D.MovePosition(transform.position + movement);
    }
}
