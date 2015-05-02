using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ObjectivesStatusScript : MonoBehaviour 
{
	public bool Active = false;
	public bool Complete = false;
	public Text ThisText;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Active == true)
		{
			ThisText.color = Color.yellow;
		}
		if (Active == false) 
		{
			ThisText.color = Color.gray;
		}
		if (Complete == true) 
		{
			ThisText.color = Color.green;
		}
	
	}


}
