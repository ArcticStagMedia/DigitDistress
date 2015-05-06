using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using System;

public class ApprovalRatingScript : MonoBehaviour 
{
	public Image ApprovalRating;
	public float FillAmount;
	public float FillTotal = 100f;
	public float FillCurrent = 20f;

	// Use this for initialization
	void Start () 
	{
		ApprovalRating = GetComponent<Image> ();
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(FillCurrent < 0f)
		{
			FillCurrent = 0f;
		}
		if(FillCurrent > 100f)
		{
			FillCurrent = 100f;
		}
		FillAmount = (FillCurrent / FillTotal );
		ApprovalRating.fillAmount = FillAmount;

	
	}

	public void ChangeRatingCurrent (float Amount)
	{
		FillCurrent = Amount;
	}
}
