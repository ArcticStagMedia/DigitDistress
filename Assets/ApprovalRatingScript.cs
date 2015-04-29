using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using System;

public class ApprovalRatingScript : MonoBehaviour
{
		public Image ApprovalRating;
		public  Text m_ApprovalNumber;
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
				FillCurrent = ApprovalSystem.CalculateAvailableApproval ();
				Mathf.Clamp (FillCurrent, 0f, 100f);
				m_ApprovalNumber.text = ((int)FillCurrent).ToString () + "%";
				FillAmount = (FillCurrent / FillTotal);
				ApprovalRating.fillAmount = FillAmount;

	
		}
}
