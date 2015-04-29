using UnityEngine;
using System.Collections;
using UnityEngine.UI;

using DigitDistress.AI.ThoughtEngine;

public class BuildingPlot : MonoBehaviour
{

		//private static BuildingManager m_BuildingMananger;
		public GameObject m_CurrentBuilding = null;
		public GameObject PlaceBuildingButton;
		public string m_BuildingName = "";


		// Use this for initialization
		void Start ()
		{
				//
		}

		// Update is called once per frame
		void Update ()
		{
				//
		}

		public void SetName (string name)
		{
				m_BuildingName = name;
		}
		public void BuildBuilding (float cost)
		{
				if (CheckBuilding (cost)) {
						if (m_CurrentBuilding == null) {
								ApprovalSystem.buyWithApproval (cost);
								m_CurrentBuilding = (GameObject)(GameObject.Instantiate (BuildingManager.getBuilding (m_BuildingName), this.transform.position, this.transform.rotation));
						}
						if (m_CurrentBuilding != null) {
								PlaceBuildingButton.SetActive (false);
						}
				}
		}


		public void RemoveBuilding ()
		{
				foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Agent")) {
						AICore ai = obj.GetComponent<AICore> ();

						if (ai.m_lBuildings.Contains (m_CurrentBuilding)) {
								ai.m_lBuildings.Remove (m_CurrentBuilding);
						}

				}
				GameObject.Destroy (m_CurrentBuilding);
				PlaceBuildingButton.SetActive (true);
		}

		public void ReplaceBuilding (float cost)
		{
				RemoveBuilding ();
				BuildBuilding (cost);
		}

		public bool CheckBuilding (float cost)
		{
				if (ApprovalSystem.checkAvailableApproval (cost)) {
						return true;
				}
				return false;
		}

}
