using UnityEngine;
using System.Collections;

public class Interact : MonoBehaviour {

	private bool selected = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		renderer.material.color = Color.white;
		selected = false;

	}
	public void OnLookEnter()
	{
		renderer.material.color = Color.red;

	}

}
