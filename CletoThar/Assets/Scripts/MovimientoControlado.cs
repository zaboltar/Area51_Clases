using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoControlado : MonoBehaviour {
    public float speed = 5;
    public float angSpeed = 20;

  	// Use this for initialization
	void Start () {
    

    // por si se desconfigura
		// this.Rigidbody.useGravity = false;
	}		// pero no se como usarlo :p
	
	// Update is called once per frame

    // si usamos transform.up el mov es relativo al obj
    // si usamos vector3.up nos refiere a los ejes globales!!
	void Update () {

		//código de mov simple vertical
        if(Input.GetKey (KeyCode.UpArrow)) {

            // b/ transform.Translate (Vector3.forward * Time.deltaTime * speed ;
            transform.position += Vector3.up * Time.deltaTime * speed ;

            // aca Hilble cambia la cam a zenital y usa vector3.forward y vect3.back

        } else if (Input.GetKey (KeyCode.DownArrow))
        {
            transform.position += Vector3.down * Time.deltaTime * speed;
        }

        //código de mov simple horizontal
        if(Input.GetKey (KeyCode.LeftArrow)) {
            transform.position += Vector3.left * Time.deltaTime * speed ;
        } else if (Input.GetKey (KeyCode.RightArrow))
        {
            transform.position += Vector3.right * Time.deltaTime * speed;
        }
		
        // tank rotation - considerar camara y desde donde se rota
        // if (Input.GetKey (KeyCode.LeftArrow)) { transform.Rotate (Vector3.down * Time.deltaTime * angSpeed );}

	}



    // void Translate (Vector3 vector){
       // transform.position += vector;
        // y añadir /b/ aunque ya vuelve este metodo obsoleto, unity lo incluye
   // }

    // antes se podia acceder directamente al rigidbody...ahora es deprecated, legacycode
    // Llamar al componente: GetComponent<ofType>
    // pedir transform: GetComponent<Transform>() ... = a transform con minuscula
    // para Rigid-body-. GetComponent<Rigidbody>().velocity = Vector3.left * speed;
    // tmb existe para arrays: GetComponentSSSSS => devuelve array
    // 
}
