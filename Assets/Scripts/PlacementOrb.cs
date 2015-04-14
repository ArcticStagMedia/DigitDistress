using UnityEngine;
using System.Collections;

using DigitDistress.AI.ThoughtEngine;

public class PlacementOrb : MonoBehaviour
{

		public GameObject BuilderObject;
		BuildingPlot m_Plot;


		// Use this for initialization
		void Start ()
		{
				BuilderObject.SetActive (false);
				m_Plot = this.GetComponent<BuildingPlot> ();
		}

		void OnTriggerEnter (Collider other)
		{
				if (other.tag == "Player") {
						BuilderObject.SetActive (true);
				}

				if (m_Plot.m_CurrentBuilding != null) {
						if (other.tag == "Agent") {
								if (other.GetComponent<AICore> ().m_lBuildings.Contains (m_Plot.m_CurrentBuilding))
										other.GetComponent<AICore> ().addBuilding (m_Plot.m_CurrentBuilding);
						}
				}
		}

		void OnTriggerExit (Collider other)
		{
				BuilderObject.SetActive (false);
		}
}
