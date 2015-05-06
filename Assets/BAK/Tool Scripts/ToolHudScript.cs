using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ToolHudScript : MonoBehaviour {
	public ToolScript T_S;

	public GameObject ToolCanvas;
	public Text txt1;
	public Text txt2;
	public Text txt3;
	public Text txt4;

	public Text TipText;

	// Use this for initialization
	void Start () {
		ToolCanvas.GetComponent<Canvas> ().enabled = false;

//		List<ToolTip> tip = new List<ToolTip>();
//
//		//List
//		tip.Add (new ToolTip ("Digits"));
//		tip.Add (new ToolTip ("The world"));
//		tip.Add (new ToolTip ("Roads"));
//		tip.Add (new ToolTip ("Insert tip"));

	}
	
	// Update is called once per frame
	void Update () {




		txt1.GetComponent<Text> ().text = "Digit Count: " + T_S.countAI;
		txt2.GetComponent<Text> ().text = "Building & Plot Count: " + T_S.countBuildingsAndPlots;
		txt3.GetComponent<Text> ().text = "Digit Used Transport Count: " + T_S.countDigitsUsedTransport;
		txt4.GetComponent<Text> ().text = "On Transport: " + T_S.DigitInside;



		if (Input.GetKeyDown (KeyCode.P)) 
		{
			ToolCanvas.GetComponent<Canvas> ().enabled = true;

			List<string> Tip = new List<string>();
			
			//List
			Tip.Add("Purchasing food and entertainment building will increase your approval");
			Tip.Add("Transport will allow digits to navigate the world quicker");
			Tip.Add("Cycles are like days and will increment by 1 every 2 minutes");
			Tip.Add("Information will be displayed on your UI tablet");
			Tip.Add("Jumping on a digits head can be a fun from of transportation");
			Tip.Add("If you find yourself with nothing to do, ask a digit");
			Tip.Add("Exploring can be a fun way to discover the world");
			
			System.Random random = new System.Random ();
			string fromList = Tip [random.Next (Tip.Count)];
			
			TipText.GetComponent<Text> ().text = "Game Tip: " + fromList;
		} 
		else if(Input.GetKeyUp (KeyCode.P))
		{
			ToolCanvas.GetComponent<Canvas> ().enabled = false;
		}
	}
}
