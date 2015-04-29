using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using System;

public class CycleScenario : MonoBehaviour
{
	 
		public float CycleTimer;
		public int CycleNumber;
		public float FillAmount;
		public Image CyclePercent;
		public float FillTotal = 120f;
		public float FillCurrent = 0f;
		public Text CycleNumberDisplay;
		// Use this for initialization
		void Start ()
		{

				CyclePercent = GetComponent<Image> ();
		}
	
		// Update is called once per frame
		void FixedUpdate ()
		{
				CycleTimer += Time.fixedDeltaTime;
				ApprovalSystem.RegenerateApproval ((100f / 120f) * Time.fixedDeltaTime);

				if (CycleTimer >= 120f) {
						CycleNumber++;
						CycleTimer = 0;
				}

				FillCurrent = CycleTimer;

				FillAmount = (FillCurrent / FillTotal);
				CyclePercent.fillAmount = FillAmount;

				CycleNumberDisplay.text = CycleNumber.ToString ();
		}
}
