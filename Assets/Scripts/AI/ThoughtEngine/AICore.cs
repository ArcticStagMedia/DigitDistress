using UnityEngine;

using System.Collections;
using System.Collections.Generic;

namespace DigitDistress.AI.ThoughtEngine
{

		public enum AiState
		{
				IDLE,
				SEARCHING,
				TRAVELLINGTOFOOD,
				TRAVELLINGTOENTER,
				EATING,
				PLAYING
		}
		public class AICore : MonoBehaviour
		{
				//public List<MemoryBase> m_MemoryList { get; private set; }
				//public List<EmotionBase> m_EmotionList { get; private set; }
				//public List<DesireBase> m_DesireList { get; private set; }
				public List<GameObject> m_lBuildings { get; private set; }

				public float m_Entertainment = 100f;
				public float m_Hunger = 100f;

				public AiState m_CurrentState = AiState.IDLE;

				Vector3 m_vTargetLocation = Vector3.zero;

				NavMeshAgent m_NavAg;
				NavMeshHit irrelevent;

					
				// Use this for initialization
				void Start ()
				{
						m_NavAg = GetComponent<NavMeshAgent> ();
						//		m_DesireList = new List<DesireBase> ();
						//		m_EmotionList = new List<EmotionBase> ();
						//		m_MemoryList = new List<MemoryBase> ();

				}
				
				// Update is called once per frame
				void Update ()
				{
						Mathf.Clamp (m_Entertainment, 0.0f, 100.0f);
						Mathf.Clamp (m_Hunger, 0.0f, 100.0f);
						switch (m_CurrentState) {
						case AiState.IDLE:
								{
										if (Random.Range (0, 40) == 20) {
												m_CurrentState = AiState.SEARCHING;
										}
										if (m_Entertainment < 20.0f) {
												if (!m_lBuildings.Find (x => x.GetComponent<BuildingScript> ().m_AssociatedEmotion == "Fun")) {
														m_CurrentState = AiState.SEARCHING;
												} else {

														m_CurrentState = AiState.TRAVELLINGTOENTER;
						
												}
										}
										if (m_Hunger < 20.0f) {
												if (!m_lBuildings.Find (x => x.GetComponent<BuildingScript> ().m_AssociatedEmotion == "Hunger")) {
														m_CurrentState = AiState.SEARCHING;
												} else {
														m_CurrentState = AiState.TRAVELLINGTOFOOD;
						
												}
										}
										break;
								}
						case AiState.SEARCHING:
								{
										if (Random.Range (0, 100) == 49) {
												m_vTargetLocation = Vector3.zero;
												m_CurrentState = AiState.IDLE;
										}
										if (m_Entertainment < 20.0f) {
												if (!m_lBuildings.Find (x => x.GetComponent<BuildingScript> ().m_AssociatedEmotion == "Fun")) {
														//
												} else {
														m_CurrentState = AiState.TRAVELLINGTOENTER;
						
												}
										}
										if (m_Hunger < 20.0f) {
												if (!m_lBuildings.Find (x => x.GetComponent<BuildingScript> ().m_AssociatedEmotion == "Hunger")) {
														//
												} else {
														m_CurrentState = AiState.TRAVELLINGTOFOOD;
						
												}
										}
										break;
										m_NavAg.Move (Vector3.zero);
								}
						case AiState.TRAVELLINGTOFOOD:
								{
										m_NavAg.Move (Vector3.zero);
										break;
								}
						case AiState.TRAVELLINGTOENTER:
								{
										m_NavAg.Move (Vector3.zero);
										break;
								}
						case AiState.EATING:
								{
										m_Hunger += Random.Range (0.2f, 0.5f);
										if (m_Hunger > 90.0f) {
												m_CurrentState = AiState.IDLE;
										}
										break;
								}
						case AiState.PLAYING:
								{
										m_Entertainment += Random.Range (0.2f, 0.5f);
										if (m_Entertainment > 90.0f) {
												m_CurrentState = AiState.IDLE;
										}
										break;
								}
						default:
								{
//
										break;
								}
						}

						
						

//While Not Recharging
						if (m_Entertainment > 0.0f && m_CurrentState != AiState.PLAYING) {
								m_Entertainment -= Random.Range (0.1f, 0.25f);
						} else {

						}

						if (m_Hunger > 0.0f && m_CurrentState != AiState.EATING) {
								m_Entertainment -= Random.Range (0.1f, 0.25f);
						} else {
//
						}					
				}

				public void addBuilding (GameObject obj)
				{
						m_lBuildings.Add (obj);
				}
				Vector3 getClosestBuilding (string bType)
				{
						Vector3 vect = Vector3.zero;
						foreach (GameObject obj in m_lBuildings.FindAll (x => x.GetComponent<BuildingScript> ().m_AssociatedEmotion == bType)) {
								if (vect == Vector3.zero) {
										vect = obj.transform.position;
								} else if (Vector3.Distance (vect, transform.position) > Vector3.Distance (obj.transform.position, transform.position)) {
										vect = obj.transform.position;
								}
						}
						return vect;
				}
				bool setNewDestination (Vector3 dest)
				{
						if (NavMesh.SamplePosition (dest, out irrelevent, Mathf.Infinity, -1)) {
								m_NavAg.SetDestination (dest);
								return true;
						} else {
								return false;
						}
						
				}
		}
}

