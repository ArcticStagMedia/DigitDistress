using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ToolHudScript : MonoBehaviour {
	public ToolScript T_S;

	public GameObject ToolCanvas;
	public Text txt1;
	public Text txt2;
	public Text txt3;

	// Use this for initialization
	void Start () {
		ToolCanvas.GetComponent<Canvas> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {


		txt1.GetComponent<Text> ().text = "Digit Count " + T_S.countAI;
		txt2.GetComponent<Text> ().text = "Building & Plot Count " + T_S.countBuildingsAndPlots;
		txt3.GetComponent<Text> ().text = "Digit Used Transport Count " + T_S.countDigitsUsedTransport;

		if (Input.GetKeyDown (KeyCode.P)) 
		{
			ToolCanvas.GetComponent<Canvas> ().enabled = true;
		} 
		else if(Input.GetKeyUp (KeyCode.P))
		{
			ToolCanvas.GetComponent<Canvas> ().enabled = false;
		}
	}
}
