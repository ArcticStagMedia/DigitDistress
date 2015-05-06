using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {

	public Transform target1;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider other)
	{
		other.transform.position = target1.position;
	}
}
