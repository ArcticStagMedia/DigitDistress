using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using System;

public class ApprovalRatingScript : MonoBehaviour 
{
	public Image ApprovalRating;
	public float FillAmount;
	public int FillTotal = 100;
	public int FillCurrent = 20;

	// Use this for initialization
	void Start () 
	{
		ApprovalRating = GetComponent<Image> ();
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(FillCurrent < 0)
		{
			FillCurrent = 0;
		}
		if(FillCurrent > 100)
		{
			FillCurrent = 100;
		}
		FillAmount = (FillCurrent * 1.0f / FillTotal);
		ApprovalRating.fillAmount = FillAmount;

	
	}

	public void ChangeRatingCurrent (int Amount)
	{
		FillCurrent = FillCurrent + Amount;
	}
}
