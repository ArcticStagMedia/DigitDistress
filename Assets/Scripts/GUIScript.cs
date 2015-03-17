using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GUIScript : MonoBehaviour 
{
	public GameObject TheCanvas;
	public static bool CanvasActive = false;
	public GameObject[] Buttons;

	// Use this for initialization
	void Start () 
	{

		Buttons = GameObject.FindGameObjectsWithTag ("Button");
	
	}
	
	// Update is called once per frame
	void Update ()
	{

		if (CanvasActive == true) 
		{
			//GetComponent<Canvas>().enabled = true;
			foreach(GameObject MyButton in Buttons)
				MyButton.GetComponent<Button>().interactable = true;

		}

		if( CanvasActive == false)
		{
			//GetComponent<Canvas>().enabled =false;
			foreach(GameObject MyButton in Buttons)
				MyButton.GetComponent<Button>().interactable = false;
		}

	
	}
}
