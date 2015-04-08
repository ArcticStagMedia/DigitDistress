using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour
{
	public Canvas canvas;
	public Canvas Controls;
	public bool IsPaused = false;
	public GameObject TheMayor;
	public bool ShowControls = false;
    private UIScript UiScript;
	// Use this for initialization
	void Start () 
	{
        UiScript = GetComponent<UIScript>();
        canvas.enabled = false;
        Controls.enabled = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyUp(KeyCode.Escape))
		{
			IsPaused = !IsPaused;
            pauseMenu();
		}
	}


	public void PauseSwap()
	{
		IsPaused = !IsPaused;
	}

	public void MenuSwap()
	{
		ShowControls = !ShowControls;
	}

    public void pauseMenu()
    {
        if (IsPaused)
        {

            Time.timeScale = 0f;
            UiScript.MovementSwitch(IsPaused);
            //Camera.main.GetComponent<MouseLook>().enabled = false;
            //TheMayor.GetComponent<MouseLook>().enabled = false;


            if (ShowControls == true)
            {
                Controls.enabled = true;
                canvas.enabled = false;
            }
            else
            {
                Controls.enabled = false;
                canvas.enabled = true;
            }

        }
        else if (!IsPaused)
        {
            Time.timeScale = 1f;
            //Camera.main.GetComponent<MouseLook>().enabled = true;
            //TheMayor.GetComponent<MouseLook>().enabled = true;
            canvas.enabled = false;
            Controls.enabled = false;
            UiScript.MovementSwitch(IsPaused);


        }
        else
        {
            print("HOW THE FUCK DID YOU GET HERE!");
        }
    }
}
