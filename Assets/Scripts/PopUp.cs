using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PopUp : MonoBehaviour 
{

	public Text ThisCanvas;

	// Use this for initialization
	void Start () 
	{
		ThisCanvas = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		//ThisCanvas.text = "Test";
	}
}
