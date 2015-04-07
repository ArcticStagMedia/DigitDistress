using UnityEngine;
using System.Collections;

public class Select : MonoBehaviour {
	bool Range = false;
	public RaycastHit hit;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		Ray ray = Camera.main.ScreenPointToRay (new Vector3 (Screen.width / 2, Screen.height / 2, 0));

		if (Physics.Raycast (ray, out hit, 100))
		{

						if (hit.collider.gameObject.GetComponent<Interact> () != null)
						{
								hit.collider.gameObject.GetComponent<Interact> ().OnLookEnter ();
								Range = true;
						}



		}
		else
		{
			Range = false;
		}
		if (Range == true && Input.GetKeyDown (KeyCode.E)) 
		{
			string[] DigitGreetings = {"Hello Mayor", "Fancy seeing you here","Lovely Day","WOW is it really you?"};
			System.Random random = new System.Random();
			string quote = DigitGreetings[random.Next(DigitGreetings.Length)];
			Debug.Log (quote);
		}
	

	
	}
}
