using UnityEngine;
using System.Collections;

public class BuildingDestroyer : MonoBehaviour 
{

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.N)) 
		{
			print ("test");
			Destroy();
		}
	
	}

	public void Destroy()
	{
		Destroy (this.gameObject);
	}
}
