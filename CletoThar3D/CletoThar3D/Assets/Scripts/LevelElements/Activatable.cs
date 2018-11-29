using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activatable : MonoBehaviour {

    // cuidado con los nobmres q ya estan reservados, como OnEnabled, OnDisabled o Pepe.
    // cuando se ejecuta el programa compilado, corre el main thread, linea x linea
    // ejecuta procesos asyncronos
    // los coroutines emulan el proceso de multithreading, son async dentro del contexto de unity
    // el multithreading se usa para procesos especificos, como networking, online o multiplayer
    // coroutines es algo como un orden in layer de los procesos
    // con iennumerator se puede jerarquizar el orden de las rutinas

    // ciclo de vida de soft: 1 analisis 2 diseño y sus patrones 3 implementacion 4 test (unit,integration, validation) 5 mantenimiento 
    // y volver al 1

    protected bool activated;

    protected List<Activator> linkedActivators = new List<Activator>();

    public void LinkActivator(Activator activator) {
        linkedActivators.Add(activator);
    }

    public Activator[] LinkedActivators () {
        return linkedActivators.ToArray();
    }

  
	

	public virtual void OnStart ( ) {



    }

    public virtual void OnActive ( ) {



    }

    public virtual void OnEnd ( ) {



    }

}
