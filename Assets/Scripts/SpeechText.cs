using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpeechText : MonoBehaviour
{
		//public Select S;
		public Interact I;

		public GameObject TheSpeechCanvas;
		public Text txt;
		public float SpeechBoxTime;
		GameObject m_Player;
		public GameObject m_DialogueManager;
		// Use this for initialization
		void Start ()
		{
				TheSpeechCanvas.GetComponent<Canvas> ().enabled = false;
				m_Player = GameObject.FindGameObjectWithTag ("Player");
				m_DialogueManager = GameObject.Find ("Dialogue Manager");
		}

		// Update is called once per frame
		void Update ()
		{

				SpeechBoxTime += Time.deltaTime;

				string[] DigitGreetings = { "Hello Mayor", "Fancy seeing you here", "Lovely Day", "WOW is it really you?" };

				System.Random random = new System.Random ();

				string quote = DigitGreetings [random.Next (DigitGreetings.Length)];

				if (m_Player != null) {
						TheSpeechCanvas.transform.LookAt (m_Player.transform.position + new Vector3 (0f, 0.5f, 0f));
						TheSpeechCanvas.transform.Rotate (0f, 180f, 0f);
				}

				if (I.selected == true && I.IsSpeaking == true) {
						SpeechBoxTime = 0;

						//txt.GetComponent<Text> ().text = quote;


						// if Happy

						//txt.GetComponent<Text>().text = GameObject.Find("GameObject").GetComponentInParent<DialougueScript>().HappyText1;
						//GameObject.Find("GameObject").GetComponentInParent<DialougueScript>().Happy();


						//if Frustrated

						//txt.GetComponent<Text>().text = GameObject.Find("GameObject").GetComponentInParent<DialougueScript>().FrustratedText1;
						//GameObject.Find("GameObject").GetComponentInParent<DialougueScript>().Frustrated();

						//if Explore

						//txt.GetComponent<Text>().text = GameObject.Find("GameObject").GetComponentInParent<DialougueScript>().ExploreText1;
						//GameObject.Find("GameObject").GetComponentInParent<DialougueScript>().Explore();

						// if Angry

						//txt.GetComponent<Text>().text = GameObject.Find("GameObject").GetComponentInParent<DialougueScript>().AngryText1;
						//GameObject.Find("GameObject").GetComponentInParent<DialougueScript>().Angry();

						// if Corrupt

						//txt.GetComponent<Text>().text = GameObject.Find("GameObject").GetComponentInParent<DialougueScript>().CorruptText1;
						//GameObject.Find("GameObject").GetComponentInParent<DialougueScript>().Corrupt();


						// if hungry

						//txt.GetComponent<Text>().text = GameObject.Find("GameObject").GetComponentInParent<DialougueScript>().HungryText1;
						//GameObject.Find("GameObject").GetComponentInParent<DialougueScript>().Hungry();

						// If Random

						txt.GetComponent<Text> ().text = m_DialogueManager.GetComponentInParent<DialougueScript> ().RandomText1;
						m_DialogueManager.GetComponentInParent<DialougueScript> ().Random ();



						TheSpeechCanvas.GetComponent<Canvas> ().enabled = true;

				}
				if (SpeechBoxTime >= 5) {
						TheSpeechCanvas.GetComponent<Canvas> ().enabled = false;
				}
		}
}
