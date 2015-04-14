using UnityEngine;
using System.Collections;

public class BoardTrain : MonoBehaviour {
	public ToolScript T_S;

	public Transform TrainRemove;
	public bool TrainAtStop;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnTriggerEnter(Collider other)
	{ 

		if (other.gameObject.tag == "Transport") 
		{
			TrainAtStop = true;
			Debug.Log ("BusBoarding");
		} 
		
		if (other.gameObject.tag == "AI" && TrainAtStop == true) 
		{
			other.gameObject.transform.position = TrainRemove.position;
			other.gameObject.SetActive(false);
			Debug.Log ("Digit on train");

			T_S.countDigitsUsedTransport++;
		}
		
		
	}
	public void OnTriggerExit (Collider other)
	{
		if (other.gameObject.tag == "Transport") 
		{
			TrainAtStop = false;
		}
	}
}
