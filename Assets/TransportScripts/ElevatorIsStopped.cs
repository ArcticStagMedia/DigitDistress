﻿using UnityEngine;
using System.Collections;

public class ElevatorIsStopped : MonoBehaviour {

	public bool ElevatorBoardable;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerStay (Collider other)
	{
		ElevatorBoardable = true;
	}
}
