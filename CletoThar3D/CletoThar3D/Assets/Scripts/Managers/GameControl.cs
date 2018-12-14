using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{

    // crearemos un singleton

    static public GameControl instance;
   // public CharacterBaseMov3D currentPlayer;
    public Try2Adapt currentPlayer;
    bool inTransition;
    public UIManager uIManager;

    public int currentLevel { get { return SceneManager.GetActiveScene().buildIndex; } }

	void Awake () {

        if (instance == null ) {
            instance = this;
            DontDestroyOnLoad(gameObject);
            } else {
            if (instance != this) {
                if (gameObject != instance.gameObject) {
                    Destroy(gameObject);
                } else {
                    Destroy(this);
                }
            }
        }

	}

    void ChangeLevel(int targetLevel){
        SceneManager.LoadScene(targetLevel);
    }

    
    
	
    public void StartRespawnProcess (){
        if (!inTransition) {
            StartCoroutine(RespawnProcess());
            inTransition = true;
        }

    } 

    public void StartLevelChangeProcess(int index) {
        if (!inTransition) {
            StartCoroutine(LevelChangeProcess(index));
            inTransition = true;
        }
    }

    IEnumerator RespawnProcess () {
        yield return uIManager.FadeProcess(currentPlayer.Respawn);


        while (!currentPlayer.grounded) {
            yield return null;
        }

        currentPlayer.EnableInput();
        inTransition = false;
    }

    IEnumerator LevelChangeProcess(int index){
        yield return uIManager.FadeProcess(ChangeLevel, index);
        inTransition = false;

    }

}

// ver delegates, punteros a funciòn, punteros de memoria, commodore style
// en vez de contener valores, tienes direccion del lugar en donde se almacena alguna valor
// delegate es un espacio de memoria al que hace referencia cierta definicion para que otros metodos accedan a èl
// deberia haber un transition manager que llame metodos del game controller .... -_-"
// para invocar action el metodo debe ser un void y no tener paràmetros!, asi se puede pasar un metodo como parametro en otro metodo
// 
