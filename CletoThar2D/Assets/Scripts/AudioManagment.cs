using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagment : MonoBehaviour {

    static public AudioManagment audioMngr;
    // la instancia se crea y se guarda en esta variable
	void Awake() {
         // se refiere a la instancia creada de audiomanager

        if (audioMngr == null) {

            audioMngr = this;
            DontDestroyOnLoad(transform.gameObject);
        } else {
            Destroy(gameObject);    
        }
	}
}