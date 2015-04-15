using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using System;

public class MainNanoClipTextScript : MonoBehaviour 
{
	public Text TotalText;
	public float ByteTotal;
	public GameObject GameControllerObject;
	public GameControllerScript GameControllerScript;

	// Use this for initialization
	void Start () 
	{
		GameControllerObject = GameObject.FindGameObjectWithTag ("GameController");
		GameControllerScript = GameControllerObject.GetComponent<GameControllerScript> ();
		TotalText = GetComponent<Text> ();

	
	}
	
	// Update is called once per frame
	void Update () 
	{
		ByteTotal = GameControllerScript.money;
		TotalText.text = "Name: Mayor Digit" + "\n" + "System: Nanoclip OS" + "\n" + "Bytes: " + ByteTotal;
	
	}
}
