using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using System;

public class MainNanoClipTextScript : MonoBehaviour 
{
	public Text TotalText;
	public int ByteTotal;

	// Use this for initialization
	void Start () 
	{
		TotalText = GetComponent<Text> ();
		TotalText.text = "Name: Mayor Digit" + "\n" + "System: Nanoclip OS" + "\n" + "Bytes: " + ByteTotal;
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
