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
	// Use this for initialization
	void Start () 
	{


	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyUp(KeyCode.Escape))
		{
			IsPaused = !IsPaused;

		}



		if (IsPaused == true)
		{

			Time.timeScale = 0f;
			//Camera.main.GetComponent<MouseLook>().enabled = false;
			//TheMayor.GetComponent<MouseLook>().enabled = false;


			if(ShowControls == true)
			{
				Controls.enabled = true;
				canvas.enabled = false;
			}
			else
			{
				Controls.enabled = false;
				canvas.enabled = true;
			}

		} else
		{
			Time.timeScale = 1f;
			//Camera.main.GetComponent<MouseLook>().enabled = true;
			//TheMayor.GetComponent<MouseLook>().enabled = true;
			canvas.enabled = false;
			Controls.enabled = false;


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
}
