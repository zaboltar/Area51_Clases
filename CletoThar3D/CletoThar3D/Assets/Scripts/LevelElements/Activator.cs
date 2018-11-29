using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour {

    public Activatable target;


    void Awake() {
        //por ahora està acà, pero podrìa estar en el start con override y virtual, no se donde; no daremos vueltas
        if (target) { target.LinkActivator(this); }
    }

	public virtual bool Use () {

        Debug.Log("Calling Use on Activator");

        return false;

    }


    protected virtual void ActivateStart(Activatable activatable) {

        // virtual es otro tipo de modificador, pero no de acceso, define si se puede sobreescribir o no
        // en el caso de un metodo protected, tiene una definicion. En cualquier otro contexto, como en el hijo, se puede encontrar el metodo
        // pero la definicion es pertinente solo en el metodo, no es dinamica.
        // en el caso de un metodo virtual, se puede REDEFINIR el metodo con OVERRIDE

        Debug.Log("Process Started Sent");

   }



    protected virtual void ActivateEnd (Activatable activatable, bool recall = true) {


        Debug.Log("Process Ending Sent");
        activatable.OnEnd();
        if (recall) {
            Activator[] activators = activatable.LinkedActivators();
            foreach (Activator activator in activators) {
                if (activator != this) { activator.ActivateEnd(activatable, false); }
            }
        }

    }


}
