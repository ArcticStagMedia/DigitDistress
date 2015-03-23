using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public void SelectScene()
    {
        Application.LoadLevel(1);
    }

	public void QuitGame()
	{
		Application.Quit ();
	}
}
