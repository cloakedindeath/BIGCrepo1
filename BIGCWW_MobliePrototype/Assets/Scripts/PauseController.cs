using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseController : MonoBehaviour 
{
	public GameObject[] pMenu;
	//public GameObject player;

	//Pause the game
	public void pauseGame()
	{
		Time.timeScale = 0;
		foreach (GameObject buttons in pMenu)
		{
			buttons.SetActive(true);
		}
	}
	//Continue the game
	public void continueGame()
	{
		Time.timeScale = 1;
		foreach (GameObject buttons in pMenu)
		{
			buttons.SetActive(false);
		}
	}
	//Return to Main menu
	public void mainMenuReturn()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene ("MainMenu");
	}

	/*public void mLeft()
	{
		player.transform.Translate ((Vector3.left) * Time.deltaTime * 50, Space.World);
	}
	public void mRight()
	{
		player.transform.Translate ((Vector3.right) * Time.deltaTime * 50, Space.World);
	}*/

}
	

