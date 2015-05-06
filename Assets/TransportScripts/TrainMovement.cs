using UnityEngine;
using System.Collections;

public class TrainMovement : MonoBehaviour {

	public Transform[] Waypoints;
	public float moveSpeed;
	public float TrainTime;
	private int currentPoint;

    public float WaypointDistance;

    //public Vector3 pos;
	
	// Use this for initialization
	void Start () {
		transform.position = Waypoints [0].position;
		currentPoint = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		TrainTime += Time.deltaTime;


        if (Vector3.Distance(transform.position, Waypoints[currentPoint].position) < WaypointDistance) 
		{
			TrainTime = 0;
			currentPoint++;
		}
		
		if (currentPoint >= Waypoints.Length) 
		{
			currentPoint = 0;
		}
		if(TrainTime >= 1)
		{
			transform.position = Vector3.MoveTowards (transform.position, Waypoints [currentPoint].position, moveSpeed * Time.deltaTime);
			transform.LookAt (Waypoints [currentPoint]);
		}
	}
}
