using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gpjDialogueHolder : MonoBehaviour {

	public string dialogue;
	private gpjDialogueManager dMan;

	public string[] dialogueLines;
	// Use this for initialization
	void Start () {
		dMan = FindObjectOfType<gpjDialogueManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D other){
		if(other.gameObject.tag == "Player"){
			if (Input.GetKeyUp(KeyCode.Z)){
				//dMan.ShowBox(dialogue);
				if (!dMan.dialogueActive) {
					dMan.dialogueLines = dialogueLines;
					dMan.currentLine = 0;
					dMan.ShowDialogue();
				}

				if (transform.parent.GetComponent<gpjVillagerMov>() != null) {
					transform.parent.GetComponent<gpjVillagerMov>().canMove = false;

				}
			}
		}
	}
}
