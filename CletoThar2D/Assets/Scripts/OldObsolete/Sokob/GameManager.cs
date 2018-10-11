using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public LevelBuilder m_LevelBuilder;
	public GameObject m_NextButton;
	private bool m_ReadyForInput;
	private Player m_Player;



	void Start()
	{
		m_NextButton.SetActive(false);
		ResetScene();
	}

	void Update() {
		Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
		moveInput.Normalize();
		if (moveInput.sqrMagnitude > 0.5) {
			if (m_ReadyForInput){
				m_ReadyForInput = false;
				m_Player.Move(moveInput);
				m_NextButton.SetActive(IsLevelComplete());
			}
		} else {
			m_ReadyForInput = true;
		}
	}

	public void NextLevel()
	{
		m_NextButton.SetActive(false);
		m_LevelBuilder.NextLevel();
		StartCoroutine(ResetSceneASync());
	}

	public void ResetScene()
	{
		StartCoroutine(ResetSceneASync());
	}

	bool IsLevelComplete()
	{
		Box[] boxes = FindObjectsOfType<Box>();
		foreach (var box in boxes) 
		{
			if (!box.m_OnCross) return false;
		}
		return true;
	}

	IEnumerator ResetSceneASync()
	{
		if (SceneManager.sceneCount > 1) {
			AsyncOperation asyncUnload = SceneManager.UnloadSceneAsync("LevelScene");
			while (!asyncUnload.isDone){
				yield return null;
				Debug.Log("Unloading...");
			}
			Debug.Log("Unload Done");
			Resources.UnloadUnusedAssets();
		}

		AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("LevelScene", LoadSceneMode.Additive);
		while (!asyncLoad.isDone)
		{
			yield return null;
			Debug.Log("Loading...");
		}	
		SceneManager.SetActiveScene(SceneManager.GetSceneByName("LevelScene"));
		m_LevelBuilder.Build();
		m_Player = FindObjectOfType<Player>();
		Debug.Log("Level loaded");
	}


}
