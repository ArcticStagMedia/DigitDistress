using UnityEngine;
using System.Collections;

public class BUSmovement : MonoBehaviour {

	public Transform[] Waypoints;
	public float moveSpeed;
	public float BusTime;
	public float WaypointDistance;
	private int currentPoint = 0;
	public Vector3 pos;
	
	// Use this for initialization
	void Start () {
		transform.position = Waypoints [0].position;
		//currentPoint = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		BusTime += Time.fixedDeltaTime;

		if(BusTime >= 5)
		{
			transform.position = Vector3.MoveTowards (transform.position, Waypoints [currentPoint].position, moveSpeed * Time.deltaTime);
			transform.LookAt (Waypoints [currentPoint]);
		}

		 if(Vector3.Distance(transform.position, Waypoints [currentPoint].position) < WaypointDistance)
		{
			currentPoint++;
			BusTime = 0;
		}

//		if (transform.position == Waypoints [currentPoint].position) 
//		{
//			currentPoint++;
//			BusTime = 0;
//			//transform.LookAt (Waypoints [currentPoint]);
//		}
		
		if(currentPoint >= Waypoints.Length) 
		{
			currentPoint = 0;
			//BusTime = 0;
		}

		pos = transform.position;
	}
}
