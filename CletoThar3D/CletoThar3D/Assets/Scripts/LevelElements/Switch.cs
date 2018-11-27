using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : Activator {

    //investigar como implementar switches -.- """

    public bool isSwitched;
    public Color activeColor;
    public Color inactiveColor;

    public Activatable target;
    // tipos de switch; pueden ser time for action, lever, button, el tiempo es otro factor. 
    // no se que es trabajar con interfaz, pero se discute como posibilidad de solucion
    // se puede mezclar herencias con manejo por interfaces...npi


	private void Start() {
        GetComponent<Renderer>().material.color = inactiveColor;
	}

    public bool Use (Activatable activatable) {
        if (!isSwitched) {
            ActivateStart(target) 
        } else {
            ActivateEnd(target)
        }

        return isSwitched;
    }




	public override void ActivateStart(Activatable activatable) {
        isSwitched = true;
        GetComponent<Renderer>().material.color = activeColor;

	}

    public override void ActivateEnd(Activatable activatable)
    {
        isSwitched = false;
        GetComponent<Renderer>().material.color = inactiveColor;

    }


}
