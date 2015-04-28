using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using System;

public class ApprovalRatingScript : MonoBehaviour 
{
	public Image ApprovalRating;
	public float FillAmount;
	public float FillTotal = 100;
	public float FillCurrent = 60;

	// Use this for initialization
	void Start () 
	{
		ApprovalRating = GetComponent<Image> ();
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		ApprovalRating.fillAmount = FillCurrent / FillTotal;

	
	}
}
