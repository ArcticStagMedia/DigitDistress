using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using System;

public class ApprovalRatingScript : MonoBehaviour 
{
	public Image ApprovalRating;
	public float FillAmount;


	// Use this for initialization
	void Start () 
	{
		ApprovalRating = GetComponent<Image> ();
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		ApprovalRating.fillAmount = .5f;

	
	}
}
