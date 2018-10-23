using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneButtonMngr : MonoBehaviour {

	


	public void SceneLoader(int SceneIndex) {

        if (AudioManagment.audioMngr != null ) {

            Destroy(AudioManagment.audioMngr.gameObject);
        }

	    SceneManager.LoadScene(SceneIndex);

	// esto debería apagar la música
	
	

	}


    public void QuitGame()
    {
#if UNITY_EDITOR

        UnityEditor.EditorApplication.isPlaying = false;
        //para el editor durante compiplaciòn de prueba

#else

        Application.Quit();
        // para compilacion externa de win?
    
#endif
    }

}
