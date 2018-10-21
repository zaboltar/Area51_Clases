using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityMov2D : MonoBehaviour {

    public float speed = 1;
    public Vector2 direction;
    public Vector3 movement { get { return direction * speed * Time.deltaTime; } }

    // Use this for initialization
    // al heredar de clases, monobehaviour lega metodos
    // polymorfismo, todo objeto dentrode una jerarquia puede ser tratado como otro rango de objeto incluido en la misma jerarquia
    // 
	void Start () {
		
	}
	
	// Update is called once per frame
    // protected hace que solo sea de su clase y de los hijos q tenga
    // pero nose puede acceder desde otro lado
    // como virtual: se mantiene la definicion para ser llamado, pero se ejecuta la sobrecarga x encima del metodo virtual
    // wtf?
    // x sobrecarga se omite la plantilla o lo q esta definido
    // sobrecarga = override
    // protected es privado para todo aquello q no sea su hijo 
	protected virtual void Update () {
        transform.Translate(movement);
        // base 1
        // la manera correcta de cargar assets es con procesos asyncronos
        // resources es un metodo que referencia info contenida en tal carpeta
        // respecto a librerias externas lo mismo con carpeta plugins
        // para files en carpeta editor no se compila, ahi se ponen instrumentos de programacion
	}
}
