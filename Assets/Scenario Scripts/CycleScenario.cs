using UnityEngine;
using System.Collections;

public class CycleScenario : MonoBehaviour {
	 
	public float CycleTimer;
	private int CycleNumber;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		CycleTimer += Time.deltaTime;

		if (CycleTimer >= 120) 
		{
			CycleNumber++;
			CycleTimer = 0;
		}

		Debug.Log ("Cycle: " + CycleNumber);
	}
}
