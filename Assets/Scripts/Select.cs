using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Select : MonoBehaviour {
	bool Range;
	public bool Speak;
	public RaycastHit hit;
	// Use this for initialization
	void Start () {
		Speak = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		Ray ray = Camera.main.ScreenPointToRay (new Vector3 (Screen.width / 2, Screen.height / 2, 0));

		if (Physics.Raycast (ray, out hit, 5))
		{

			if (hit.collider.gameObject.GetComponent<Interact> () != null)
			{
				hit.collider.gameObject.GetComponent<Interact> ().OnLookEnter ();
				Range = true;
			}
			if (Range == true && Input.GetKeyDown (KeyCode.E)) 
			{
				Speak = true;
			}
			else Speak = false;


		}
		else
		{
			Range = false;
		}
	
	}
}
