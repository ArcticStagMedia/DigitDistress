using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TutorialSpeechScript : MonoBehaviour {

	//public Select S;
	public Interact I;
	
	public GameObject TheSpeechCanvas;
	public Text txt;
	public float SpeechBoxTime;
	GameObject m_Player;

	string DigitGreetings =  "Press Q to bring up your UI tablet";
	string DigitGreetings1 =  "WASD to move around and the mouse to look";
	string DigitGreetings2 =  "Go to the purple spanners to build";
	string DigitGreetings3 =  "To keep digits happy build them entertainment and food buildings";

	// Use this for initialization
	void Start () {
		TheSpeechCanvas.GetComponent<Canvas>().enabled = true;
		m_Player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		SpeechBoxTime += Time.deltaTime;

		if (SpeechBoxTime <= 10) 
		{
			txt.GetComponent<Text> ().text = "" + DigitGreetings;
			//string quote = DigitGreetings;
		}
		if (SpeechBoxTime >= 11) 
		{
			txt.GetComponent<Text> ().text = "" + DigitGreetings1;
			//string quote = DigitGreetings1;
		}
		if (SpeechBoxTime >= 16) 
		{
			txt.GetComponent<Text> ().text = "" + DigitGreetings2;
			//string quote = DigitGreetings2;
		}
		if (SpeechBoxTime >= 21) 
		{
			txt.GetComponent<Text> ().text = "" + DigitGreetings3;
			//string quote = DigitGreetings3;
		}

		
//		System.Random random = new System.Random();
		

		
		if (m_Player != null)
		{
			TheSpeechCanvas.transform.LookAt(m_Player.transform.position + new Vector3(0f, 0.5f, 0f));
			TheSpeechCanvas.transform.Rotate(0f, 180f, 0f);
		}
		
//		if (I.selected == true && I.IsSpeaking == true) 
//		{
//			SpeechBoxTime = 0;
//		}


		GameObject.Find("GameObject").GetComponentInParent<DialougueScript>().Random();
		
		
		
		//TheSpeechCanvas.GetComponent<Canvas>().enabled = true;

//		if (SpeechBoxTime == 0)
//		{
//			TheSpeechCanvas.GetComponent<Canvas>().enabled = false;
//		}
		
	}

}
