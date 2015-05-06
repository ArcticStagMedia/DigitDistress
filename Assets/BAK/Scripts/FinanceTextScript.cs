using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using System;

public class FinanceTextScript : MonoBehaviour 
{
	public static Text FinanceText;
	public static List<string> FinanceTextRecordList;
	public int MaxFinanceRecord;
	public static string FDisplay;
	public int test = 0;

	// Use this for initialization
	void Start () 
	{
		FinanceText = GetComponent<Text> ();
	
		FinanceTextRecordList = new List<string> ();




	}
	
	// Update is called once per frame
	void Update ()
	{


		if (Input.GetKeyUp (KeyCode.N)) 
		{
		
			test = test +1;

			AddFinanceRecord("Built", "Building", test);
		}
	}

	public static void UpdateFinanceText()
	{	
		FDisplay = "";

		foreach (string msg in FinanceTextRecordList) 
		{
			FDisplay = FDisplay.ToString() + msg.ToString() + "\n" + "\n";
		}
		FinanceText.text = FDisplay;
	}

	public static void AddFinanceRecord(string How, string What, int Amount)
	{
		DateTime WhatTime = DateTime.Now;
		if (FinanceTextRecordList.Count < 25) 
		{
			FinanceTextRecordList.Reverse();
			FinanceTextRecordList.Add ("[" + WhatTime.ToShortTimeString() + "]: " + How + " " + What + " For $" + Amount);
			FinanceTextRecordList.Reverse();
		}
		if (FinanceTextRecordList.Count >= 25) 
		{
			FinanceTextRecordList.Reverse();
			FinanceTextRecordList.RemoveAt(0);
			FinanceTextRecordList.Add ("[" + WhatTime.ToShortTimeString() + "]" + How + " " + What + " For $" + Amount);
			FinanceTextRecordList.Reverse();
		}

		UpdateFinanceText ();

	}

	public void BuiltMcafee ()
	{
		AddFinanceRecord ("Built", "Mcafee", 50);
	}

	public void BuiltHardDisk()
	{
		AddFinanceRecord ("Built", "Hard Disk", 250);
	}
}
