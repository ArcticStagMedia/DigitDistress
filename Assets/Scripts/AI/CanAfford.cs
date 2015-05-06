using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CanAfford : MonoBehaviour {

	public ApprovalRatingScript m_Approval;
	public Text m_CantAfford;
	public Button m_NextButton;
	public float m_Cost;
	// Use this for initialization
	void Start () {
		//m_Approval = GameObject.FindGameObjectWithTag ("Player").GetComponentInChildren<ApprovalRatingScript>();
		m_NextButton.gameObject.SetActive(m_Approval.CheckRating (m_Cost));
		m_CantAfford.gameObject.SetActive(!m_Approval.CheckRating (m_Cost));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnEnable()
	{
		m_NextButton.gameObject.SetActive(m_Approval.CheckRating (m_Cost));
		m_CantAfford.gameObject.SetActive(!m_Approval.CheckRating (m_Cost));
		}
}
