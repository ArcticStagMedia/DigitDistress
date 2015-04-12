using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpeechText : MonoBehaviour {
	public Select S;

	public GameObject TheSpeechCanvas;
	public Text txt;
	public float SpeechBoxTime;
	// Use this for initialization
	void Start () {
		TheSpeechCanvas.GetComponent<Canvas> ().enabled = false;


	}
	
	// Update is called once per frame
	void Update () {

		SpeechBoxTime += Time.deltaTime;

		string[] DigitGreetings = {"Hello Mayor", "Fancy seeing you here","Lovely Day","WOW is it really you?"};
		System.Random random = new System.Random ();
		string quote = DigitGreetings [random.Next (DigitGreetings.Length)];

		if (S.Speak == true) 
		{
			SpeechBoxTime = 0;
			txt.GetComponent<Text> ().text = quote;
			TheSpeechCanvas.GetComponent<Canvas> ().enabled = true;

		}
		if (SpeechBoxTime >= 5) 
		{
			TheSpeechCanvas.GetComponent<Canvas> ().enabled = false;
		}
	}
}
