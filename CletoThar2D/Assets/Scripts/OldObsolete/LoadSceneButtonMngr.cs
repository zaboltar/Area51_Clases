using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneButtonMngr : MonoBehaviour {

	


	public void SceneLoader(int SceneIndex) {

	SceneManager.LoadScene(SceneIndex);
	// esto debería apagar la música
	
	

	}

}
