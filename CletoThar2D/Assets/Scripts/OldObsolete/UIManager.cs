using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public Text objectiveText;

	// Use this for initialization
	public void RefreshText (string prefix, object value) {
        objectiveText.text = prefix + value;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
