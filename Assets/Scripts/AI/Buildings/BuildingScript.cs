using UnityEngine;
using System.Collections;

using DigitDistress.AI.ThoughtEngine;

public class BuildingScript : MonoBehaviour
{
		public string m_AssociatedEmotion;
	public float m_Cost;

		// Use this for initialization
		void Start ()
		{
		GameObject.FindGameObjectWithTag ("Player").GetComponentInChildren<ApprovalRatingScript> ().AddRating (m_Cost);
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		void OnCollisionEnter (Collision other)
		{
				if (other.gameObject.tag == "Agent") {
						other.gameObject.GetComponent<AICore> ().setState (m_AssociatedEmotion);
				}
		}
}
