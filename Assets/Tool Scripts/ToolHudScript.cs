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



		if (Input.GetKeyDown (KeyCode.P)) 
		{
			ToolCanvas.GetComponent<Canvas> ().enabled = true;

			List<string> Tip = new List<string>();
			
			//List
			Tip.Add("Tip1");
			Tip.Add("Tip2");
			Tip.Add("Tip3");
			Tip.Add("Tip4");
			
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
