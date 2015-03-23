using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour
{
	public Canvas canvas;
	public bool IsPaused = false;
	public GameObject TheMayor;
	// Use this for initialization
	void Start () 
	{

		canvas.enabled = false;
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
			Camera.main.GetComponent<MouseLook>().enabled = false;
			TheMayor.GetComponent<MouseLook>().enabled = false;
			canvas.enabled = true;
			Screen.lockCursor = false;

		} else
		{
			Time.timeScale = 1f;
			Camera.main.GetComponent<MouseLook>().enabled = true;
			TheMayor.GetComponent<MouseLook>().enabled = true;
			canvas.enabled = false;
			Screen.lockCursor = true;

		}
	}


	public void PauseSwap()
	{
		IsPaused = !IsPaused;
	}
}
