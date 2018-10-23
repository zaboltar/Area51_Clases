using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonActions : MonoBehaviour
{

    public void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
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
