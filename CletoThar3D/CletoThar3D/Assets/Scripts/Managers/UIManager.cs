using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;



public class UIManager : MonoBehaviour {

    public Image fadePanel;
	
    public IEnumerator FadeProcess(Action fadeCall) {

        fadePanel.gameObject.SetActive(true);
        fadePanel.enabled = true;

        while (fadePanel.color.a != 1) {
            MoveImageAlpha(fadePanel, 1, 2f * Time.deltaTime);
            yield return null;  
        }

        //external desired method should run here!
        fadeCall.Invoke();

        while (fadePanel.color.a != 0)
        {
            MoveImageAlpha(fadePanel, 0, 2f * Time.deltaTime);
            yield return null;
        }

        Debug.Log("Made it!");


          
    
    }

    void MoveImageAlpha (Image image, float targetAlpha, float speed) {
        Color color = image.color;
        color.a = Mathf.MoveTowards(image.color.a, targetAlpha, speed);
        image.color = color;
    }

}
