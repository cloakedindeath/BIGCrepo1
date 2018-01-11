using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour 
{
	//start game
	public void goToGame()
	{
		SceneManager.LoadScene ("Game 1");
	}
	//Exit game (remove at some point)
	public void quit()
	{
		Application.Quit();
		Debug.Log ("Quit Selected");
	}
}
