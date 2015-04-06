using UnityEngine;
using System.Collections;

public class DepartTrain : MonoBehaviour {

	public Transform AIprefab;
	public Transform DepartTrainTransform;
	int i = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerStay(Collider other)
	{
		if (other.gameObject.tag == "Train") 
		{
			while (i < 5) 
			{
				Instantiate(AIprefab, DepartTrainTransform.position, DepartTrainTransform.rotation);
				i++;
			}
		}
	
	}
	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Train") 
		{
			i = 0;
		}
	}
}
