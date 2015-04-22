using UnityEngine;
using System.Collections;

public class TrainMovement : MonoBehaviour {

	public Transform[] Waypoints;
	public float moveSpeed;
	public float TrainTime;
	private int currentPoint;
	
	// Use this for initialization
	void Start () {
		transform.position = Waypoints [0].position;
		currentPoint = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		TrainTime += Time.deltaTime;
		
		
		if (transform.position == Waypoints [currentPoint].position) 
		{
			TrainTime = 0;
			currentPoint++;
		}
		
		if (currentPoint >= Waypoints.Length) 
		{
			currentPoint = 0;
		}
		if(TrainTime >= 15)
		{
			transform.position = Vector3.MoveTowards (transform.position, Waypoints [currentPoint].position, moveSpeed * Time.deltaTime);
			//transform.LookAt (Waypoints [currentPoint]);
		}
	}
}
