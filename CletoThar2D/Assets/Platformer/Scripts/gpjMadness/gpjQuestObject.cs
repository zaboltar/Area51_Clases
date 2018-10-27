using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gpjQuestObject : MonoBehaviour {

	public int questNumber;
	public gpjQuestManager theQM;

	public string startText;
	public string endText;

	public bool isItemQuest;
	public string targetItem;

	public bool isEnemyQuest;
	public string targetEnemy;
	public int enemiesToKill;
	private int enemyKillCount;


	void Start () {
		
	}
	
	



	void Update () {
		if (isItemQuest){
			if (theQM.itemCollected == targetItem){
				theQM.itemCollected = null;
				EndQuest();
			}
		}

		if (isEnemyQuest){
				if (theQM.enemyKilled == targetEnemy){
					theQM.enemyKilled = null;
					enemyKillCount++; 
				}

				if (enemyKillCount >= enemiesToKill) {
					EndQuest();
				}
		}
	}





	public void StartQuest(){
		theQM.ShowQuestText(startText);
	}





	public void EndQuest(){

		theQM.ShowQuestText(endText);

		theQM.questCompleted[questNumber] = true;

		gameObject.SetActive(false);
	}



}
