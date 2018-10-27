using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gpjDialogueManager : MonoBehaviour {

	public GameObject dBox;
	public Text dText;
	public bool dialogueActive;
	public string[] dialogueLines;
	public int currentLine;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (dialogueActive && Input.GetKeyUp(KeyCode.Z)) {
			//dBox.SetActive(false);	
			//dialogueActive = false;
			currentLine++;
		}

		if(currentLine >= dialogueLines.Length) {
			dBox.SetActive(false);	
			dialogueActive = false;
			currentLine = 0;
		}

		dText.text = dialogueLines[currentLine];
	}

	public void ShowBox(string dialogue){
		dialogueActive = true;
		dBox.SetActive(true);
		dText.text = dialogue;
	}

	public void ShowDialogue() {
		dialogueActive = true;
		dBox.SetActive(true);
	}
}
