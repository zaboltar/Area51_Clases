using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gpjQuestItem : MonoBehaviour {

	public int questNumber;
	private gpjQuestManager theQM;

	public string itemName;

	// Use this for initialization
	void Start () {
		theQM = FindObjectOfType<gpjQuestManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.name == "Player"){
			if (!theQM.questCompleted[questNumber] && theQM.quests[questNumber].gameObject.activeSelf){
				theQM.itemCollected = itemName;
				gameObject.SetActive(false);
			}
		}
	}
}
