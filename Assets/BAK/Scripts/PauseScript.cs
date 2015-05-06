using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour
{
	public Canvas canvas;
	public Canvas Controls;
	public Canvas Sound;
	public bool IsPaused = false;
	public GameObject TheMayor;
	public bool ShowControls = false;
	public bool ShowSoundControls = false;
	public bool ShowPauseMenu = true;
    private UIScript UiScript;
	// Use this for initialization
	void Start () 
	{
        UiScript = GetComponent<UIScript>();
        canvas.enabled = false;
        Controls.enabled = false;
		Sound.enabled = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyUp(KeyCode.Escape))
		{
            PauseSwap();
            pauseMenu();

			if(ShowPauseMenu == false)
			{
				ShowPauseMenu = true;
			}
		}

		if (IsPaused)
		{
			
			Time.timeScale = 0f;

			//Camera.main.GetComponent<MouseLook>().enabled = false;
			//TheMayor.GetComponent<MouseLook>().enabled = false;
			
		}
		else if (!IsPaused)
		{
			Time.timeScale = 1f;
			//Camera.main.GetComponent<MouseLook>().enabled = true;
			//TheMayor.GetComponent<MouseLook>().enabled = true;
			canvas.enabled = false;
			Controls.enabled = false;
			Sound.enabled = false;

			
			
		}
		else
		{
			print("HOW THE FUCK DID YOU GET HERE!");
		}
	}


	public void PauseSwap()
	{
		IsPaused = !IsPaused;
	}

	public void MenuSwap()
	{
		Controls.enabled = true;
		canvas.enabled = false;
		Sound.enabled = false;

	}

    public void pauseMenu()
    {
		UiScript.MovementSwitch(IsPaused);
		Controls.enabled = false;
		Sound.enabled = false;
		canvas.enabled = true;
    }

    public void MainMenuButton()
    {
        Application.LoadLevel(0);
    }

	public void ShowSound()
	{
		Controls.enabled = false;
		canvas.enabled = false;
		Sound.enabled = true;
	}
}
