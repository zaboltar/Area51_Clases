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

}
