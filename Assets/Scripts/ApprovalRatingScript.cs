using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using System;

public class ApprovalRatingScript : MonoBehaviour 
{
	public Image ApprovalRating;
	public Text ApprovalNumber;
	private float FillAmount;
	private float FillTotal = 100f;
	public float FillCurrent = 50f;

	// Use this for initialization
	void Start () 
	{
		ApprovalRating = GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () 
	{

		FillCurrent = Mathf.Clamp (FillCurrent, 0.0f, 100.0f);
		FillAmount = (FillCurrent / FillTotal );
		ApprovalRating.fillAmount = FillAmount;
		ApprovalNumber.text = ((int)FillCurrent).ToString ();

	}

	public void AddRating (float Amount)
	{
		FillCurrent += Amount;
	}

	public bool CheckRating(float amount)
	{
		if (amount > FillCurrent) {
			return false;
				}
		return true;
	}
}
