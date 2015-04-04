using UnityEngine;
using System.Collections;

public class Elevator : MonoBehaviour {

	public Transform[] Waypoints;
	public float moveSpeed;
	private int currentPoint;
	public float EleTime;
	public float ElevatorWait;
	public float ElevatorRiseTime;
	// Use this for initialization
	void Start () {
		transform.position = Waypoints [0].position;
		currentPoint = 0;

	}
	
	// Update is called once per frame
	void Update () {

		EleTime += Time.deltaTime;

		if (EleTime >= ElevatorRiseTime) 
		{
			EleTime = 0;
		}

		if (transform.position == Waypoints [currentPoint].position) 
		{
			currentPoint++;
		}
		
		if (currentPoint >= Waypoints.Length) 
		{
			currentPoint = 0;
		}
		if (EleTime >= ElevatorWait) 
		{
			transform.position = Vector3.MoveTowards (transform.position, Waypoints [currentPoint].position, moveSpeed * Time.deltaTime);
		}
	}
}
