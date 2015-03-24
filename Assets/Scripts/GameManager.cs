using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour 
{
	public Canvas MainMenu;
	public Canvas Instructions;

	public void SelectScene()
    {
        Application.LoadLevel(1);
    }

	public void QuitGame()
	{
		Application.Quit ();
	}

	public void ShowInstructions()
	{
		MainMenu.enabled = false;
		Instructions.enabled = true;
	}

	public void ShowMainMenu()
	{
		MainMenu.enabled = true;
		Instructions.enabled = false;
	}
}
