using UnityEngine;
using System.Collections;

public class BoardTrain : MonoBehaviour {

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

		if (other.gameObject.tag == "Train") 
		{
			TrainAtStop = true;
			Debug.Log ("BusBoarding");
		} 
		
		if (other.gameObject.tag == "Digit" && TrainAtStop == true) 
		{
			other.gameObject.transform.position = TrainRemove.position;
			other.gameObject.SetActive(false);
			Debug.Log ("Digit on train");
			
		}
		
		
	}
	public void OnTriggerExit (Collider other)
	{
		if (other.gameObject.tag == "Train") 
		{
			TrainAtStop = false;
		}
	}
}
