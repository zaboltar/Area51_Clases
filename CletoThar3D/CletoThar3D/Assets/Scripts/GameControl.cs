using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour {

    // crearemos un singleton

    static public GameControl instance;
    public CharacterBaseMov3D currentPlayer;
    bool inTransition;

	void Awake () {

        if (instance == null ) {
            instance = this;
            } else {
            if (instance != this) {
                Destroy(this);
            }
        }

	}
	
    public void StartRespawnProcess (){
        if (!inTransition) {
            StartCoroutine(RespawnProcess());
            inTransition = true;
        }

    } 

    IEnumerator RespawnProcess () {
        yield return new WaitForSeconds(3);
        currentPlayer.Respawn();
        while (!currentPlayer.grounded) {
            yield return null;
        }

        //yield return new WaitUntil( () => currentPlayer.grounded);
        currentPlayer.EnableInput();
        inTransition = false;
    }

}
