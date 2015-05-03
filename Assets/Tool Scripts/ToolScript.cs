using UnityEngine;
using System.Collections;

public class ToolScript : MonoBehaviour {

	private GameObject[] getCount;
	private GameObject[] getCountB;
	
	public int countAI;
	public int countBuildingsAndPlots;
	public int countDigitsUsedTransport;
	// Use this for initialization
	void Start () {
		countDigitsUsedTransport = 0;
	}
	
	// Update is called once per frame
	void Update () {
		getCount = GameObject.FindGameObjectsWithTag ("AI");
		countAI = getCount.Length;

		getCountB = GameObject.FindGameObjectsWithTag ("Building");
		countBuildingsAndPlots = getCountB.Length;
	}
}
