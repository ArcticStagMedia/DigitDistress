using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using System;

public class ObjectivesScript : MonoBehaviour 
{
	public List<GameObject> ObjectivesList;
	public int CurrentActiveObjectiveNumber = 0;
	public GameObject TheCurrentObjective;

	// Use this for initialization
	void Start () 
	{



	}
	
	// Update is called once per frame
	void Update () 
	{
		TheCurrentObjective = ObjectivesList [CurrentActiveObjectiveNumber];
		TheCurrentObjective.GetComponent<ObjectivesStatusScript> ().Active = true;



		if (Input.GetKeyDown (KeyCode.M)) 
		{
			CompleteCurrentObjective();
		}
	
	}


	public void CompleteCurrentObjective()
	{
		TheCurrentObjective.GetComponent<ObjectivesStatusScript> ().Complete = true;
		CurrentActiveObjectiveNumber++;
	}
}
