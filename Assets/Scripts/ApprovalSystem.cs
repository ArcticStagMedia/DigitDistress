using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using DigitDistress.AI.ThoughtEngine;

public static class ApprovalSystem
{

		static float m_BuyApproval = 100f;

		static List<AICore> m_lAgents = new List<AICore> ();

		public static void addToDigitList (AICore newObj)
		{
				if (!m_lAgents.Contains (newObj)) {
						m_lAgents.Add (newObj);
				}
		}

		public static float getAverageHappiness ()
		{
				float average = 0;
				float highest = -1;
				float lowest = -1;
				foreach (AICore core in m_lAgents) {
						average += core.m_Approval;
						if (highest < 0 || highest < core.m_Approval) {
								highest = core.m_Approval;
						} else if (lowest < 0 || lowest > core.m_Approval) {
								lowest = core.m_Approval;
						}
				}
				average = average / m_lAgents.Count;
				average = (highest + lowest + average) / 3;
				return (average / 2);
		}

		public static bool checkAvailableApproval (float need)
		{
				if (need <= CalculateAvailableApproval ()) {
						return true;
				}
				return false;
		}

		public static float CalculateAvailableApproval ()
		{
				float available = m_BuyApproval + getAverageHappiness () - 50f;
				return available;
		}

		public static void buyWithApproval (float amount)
		{
				m_BuyApproval -= amount;
		}

		public static void RegenerateApproval (float regen)
		{
				if (m_BuyApproval < 100f) {
						m_BuyApproval += regen;
				}
		}

}
