using UnityEngine;
using System.Collections;

public class CycleScenario : MonoBehaviour {
	 
	private float CycleTimer;
	public int CycleNumber;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		CycleTimer += Time.fixedDeltaTime;

		if (CycleTimer >= 120f) 
		{
			CycleNumber++;
			CycleTimer = 0f;
			Debug.Log ("Cycle: " + CycleNumber);
		}


	}
}
