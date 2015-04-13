using UnityEngine;
using System.Collections;

public class Interact : MonoBehaviour {

	public bool selected;
	public bool IsSpeaking;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		renderer.material.color = Color.white;
		//selected = false;

	}
	public void OnLookEnter()
	{
		selected = true;
		renderer.material.color = Color.red;

		if (selected == true && Input.GetKeyDown (KeyCode.E)) 
		{
			IsSpeaking = true;
		} 
		else 
		{
			IsSpeaking = false;
		}

	}

}
