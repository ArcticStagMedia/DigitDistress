using UnityEngine;
using UnityEngine.UI;

using System.Collections;
using System.Collections.Generic;

public class BuildingUIManager : MonoBehaviour
{

		public List<Transform> m_lUIChildren { get; private set; }
		public Transform m_tActive { get; private set; }

		// Use this for initialization
		void Start ()
		{
				m_lUIChildren = new List<Transform> ();
				m_lUIChildren.AddRange (GetComponentsInChildren<Transform> (true));
				
				m_lUIChildren.RemoveAll (x => x.gameObject.layer != LayerMask.NameToLayer ("UI"));
				m_lUIChildren.RemoveAll (x => !x.name.Contains ("Panel"));

				//Debug.Log (m_lUIChildren.Count);
				//m_lUIChildren.Remove (this.transform);

				m_tActive = m_lUIChildren.Find (x => x.gameObject.name.Contains ("Main"));
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		public void OpenBuildingPanel (string BuildingName)
		{
				Transform temp = m_tActive;
				m_tActive = m_lUIChildren.Find (x => x.gameObject.name.Contains (BuildingName));
				m_tActive.gameObject.SetActive (true);
				temp.gameObject.SetActive (false);
		}

		public void ClosePanels ()
		{
				m_lUIChildren.ForEach (y => y.gameObject.SetActive (false));
		}
}
