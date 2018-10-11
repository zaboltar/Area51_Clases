using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {

    static public GameControl instance;
    //se habilita para otros scripts!

    // esta es la definiciòn
    public enum LevelObjective {
        Collect,
        Destroy,
        ReachPoint
    }
    // un enum almacena distintas posibilidades de una variable ... de numeros enteros con palabras
    // al definir un enum tb se define un tipo, como el de una clase, solo que ennumerable
    // los valores se indexan automatica y progresivamente
    // cuando crear un enum? ... cuando haya mas de 2 valores (para 2 = booleano!)

    //aca va la variable
    public LevelObjective levelObjective;
    public int objectiveCount;
    public string objectivePrefix;
    public UIManager uiManager;

    public List<MonoBehaviour> objectiveInstances = new List<MonoBehaviour>();

	private void Awake() {
        if (!instance) {
            instance = this;
        }
	}
    // especie de patron de singleton // pero no totalmente
    // esto debe ocurrir antes del resto, hence the awake choice

	void Start () {
        
        Init ();

	}


	void Init () {

        if ( levelObjective == LevelObjective.Collect) {
            ReselectInstances (typeof(CollectableObject));

        } else if (levelObjective == LevelObjective.Destroy) {
            ReselectInstances(typeof(DestroyableObject));
        }

        uiManager.RefreshText(objectivePrefix, objectiveCount);

	}
	
    void ReselectInstances (System.Type type) {
        objectiveInstances = objectiveInstances.FindAll(script => script.GetType() == type);
        foreach (var script in objectiveInstances) {
            objectiveCount++;

        }

        objectivePrefix = levelObjective + ": ";
    }


    public void CheckInstancePoint(MonoBehaviour script) {
        if (objectiveInstances.Contains(script)) {
            objectiveInstances.Remove(script);
            objectiveCount--;
        }
        CheckLevelObjetives();
    }

    void CheckLevelObjetives() {
        uiManager.RefreshText(objectivePrefix, objectiveCount);
        if (objectiveCount <= 0) {
            NextLevel ();
        }
    }


	void Update () {
		
	}


    public void RestartLevel () {
        SwitchScene(SceneManager.GetActiveScene().name);
    }


    public void NextLevel (){
        SwitchScene(null);
    }


    void SwitchScene (string sceneName) {
        ClearSceneData();
        if (string.IsNullOrEmpty(sceneName)) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }    else {
            SceneManager.LoadScene(sceneName);
        }
    }


    void ClearSceneData () {
        objectiveCount = 0;
    }


}


// ver all design patterns en google play store
// creacional y comportamiento es bastante importante
// para videojuegos se usa observer
// es como un administrador de eventos idealmente
// junta todos los recursos que el resto de clases utilizar para el control general del juego
// es este script quien deberìa implementar tales manejos globales y admin de eventos y demas

