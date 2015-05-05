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

	public string DigitGreetings;
    public string DigitGreetings1;


	string DigitGreetings2 =  "Press Q to open nano- clip";
	string DigitGreetings3 =  "To keep digits happy build them entertainment and food buildings";

    public AudioClip dia1;

    public AudioClip dia2;

    private AudioSource AS;

	// Use this for initialization
	void Start () 
    {
        AS = GetComponent<AudioSource>();

		TheSpeechCanvas.GetComponent<Canvas>().enabled = true;
		m_Player = GameObject.FindGameObjectWithTag("Player");

        AS.clip = dia1;
        AS.Play();

	}
	
	// Update is called once per frame
	void Update () {
		SpeechBoxTime += Time.deltaTime;

       

		if (SpeechBoxTime <= 10) 
		{
			txt.GetComponent<Text> ().text = "" + DigitGreetings;
            //AS.clip = dia1;
            //AS.Play();
			//string quote = DigitGreetings;
		}
		if (SpeechBoxTime >= 11) 
		{
			txt.GetComponent<Text> ().text = "" + DigitGreetings2;
			//string quote = DigitGreetings1;
		}
		if (SpeechBoxTime >= 14) 
		{
			txt.GetComponent<Text> ().text = "" + DigitGreetings1;
            AS.clip = dia2;
            AS.Play();
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
