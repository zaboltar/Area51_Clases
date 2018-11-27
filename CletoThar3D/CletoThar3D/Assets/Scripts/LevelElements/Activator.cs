using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour {

    public virtual void ActivateStart(Activatable activatable) {
        // virtual es otro tipo de modificador, pero no de acceso, define si se puede sobreescribir o no
        // en el caso de un metodo protected, tiene una definicion. En cualquier otro contexto, como en el hijo, se puede encontrar el metodo
        // pero la definicion es pertinente solo en el metodo, no es dinamica.
        // en el caso de un metodo virtual, se puede REDEFINIR el metodo con OVERRIDE

        Debug.Log("Process Started Sent");





    }
}
