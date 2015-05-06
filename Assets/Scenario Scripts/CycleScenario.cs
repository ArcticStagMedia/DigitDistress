using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using System;
using DigitDistress.AI.ThoughtEngine;

public class CycleScenario : MonoBehaviour {
	 
	public float CycleTimer;
	public int CycleNumber;
	public float FillAmount;
	public Image CyclePercent;
	//public float FillTotal = 120f;
	public float FillCurrent = 0f;
	public float CycleLength = 150f;
	public Text CycleNumberDisplay;
	public ApprovalRatingScript m_Approval;
	private List<Transform> m_lDigits;

	// Use this for initialization
	void Awake () 
	{
		CyclePercent = GetComponent<Image> ();
		m_lDigits = new List<Transform> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		CycleTimer += Time.fixedDeltaTime;

		if (CycleTimer >= CycleLength) 
		{
			CycleNumber++;
			CycleTimer = 0;

			if (m_Approval != null) {
				float gainedApproval = 0.0f;
				foreach (Transform t in m_lDigits)
				{
					AICore temp = t.gameObject.GetComponent<AICore>();
					if (temp.m_Happiness > 0.0f)
					{
						gainedApproval ++;
					}
					else if (temp.m_Happiness < 0.0f)
					{
						gainedApproval --;
					}
				}
				m_Approval.AddRating(gainedApproval);
			}
		}

		FillCurrent = CycleTimer;

		FillAmount = (FillCurrent / CycleLength );
		CyclePercent.fillAmount = FillAmount;

		CycleNumberDisplay.text = CycleNumber.ToString ();


	}

	public void addDigit(GameObject newDig)
	{
		m_lDigits.Add (newDig.transform);
		}
	
}
