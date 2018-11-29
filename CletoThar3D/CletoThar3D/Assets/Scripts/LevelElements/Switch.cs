using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : Activator {

    //investigar como implementar switches -.- """

    public bool isSwitched;
    public Color activeColor;
    public Color inactiveColor;



    // tipos de switch; pueden ser time for action, lever, button, el tiempo es otro factor. 
    // no se que es trabajar con interfaz, pero se discute como posibilidad de solucion
    // se puede mezclar herencias con manejo por interfaces...npi


	private void Start() {
        GetComponent<Renderer>().material.color = inactiveColor;
	}


    public override bool Use () {
        if (!isSwitched) { ActivateStart(target); } else { ActivateEnd(target); }
        return isSwitched;
    }

    protected override void ActivateStart (Activatable activatable) {
        isSwitched = true;
        GetComponent<Renderer>().material.color = activeColor;
        Debug.Log(activatable.name + "Start");
        activatable.OnStart();
    }

    protected override void ActivateEnd (Activatable activatable, bool recall = true) {
        isSwitched = false;
        GetComponent<Renderer>().material.color = inactiveColor;
        Debug.Log(activatable.name + "End");
        base.ActivateEnd(activatable, recall);
    }
}