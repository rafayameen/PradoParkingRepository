using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {
	
	public static UIManager instance;

	[Header("Panels")]
	public GameObject levelCompletePanel;
	public GameObject levelFailedPanel;
	public GameObject pausePanel;
	public GameObject timeUpPanel;

	[Header("MainMenuScene")]
	public string mainMenuSceneName;

	void Awake()
	{
		if (instance == null)
			instance = this;
	}

	public void LevelComplete()
	{
		Time.timeScale = 0;
		levelCompletePanel.SetActive (true);
	}

	public void LevelFailed()
	{
		Time.timeScale = 0;
		levelFailedPanel.SetActive (true);
	}

	public void PauseGame()
	{
		Time.timeScale = 0;
		pausePanel.SetActive (true);
	}

	public void Resume()
	{
		Time.timeScale = 1;
		pausePanel.SetActive (false);
	}

	public void TimeUp()
	{
		Time.timeScale = 0;
		timeUpPanel.SetActive (true);
	}

	public void MoreGames(string url)
	{
		Application.OpenURL (url);
	}

	public void BackToHome()
	{
		SceneManager.LoadScene (mainMenuSceneName);
	}

	public void Restart()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}

	public void NextLevel()
	{
		
	}

}
