using UnityEngine;
using System.Collections;

public class Elevator : MonoBehaviour {

	public Transform[] Waypoints;
	public float moveSpeed;
	public float EleTime;
	private int currentPoint;

    public float WaypointDistance;
	
	// Use this for initialization
	void Start () {
		transform.position = Waypoints [0].position;
		currentPoint = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		EleTime += Time.deltaTime;


        if (Vector3.Distance(transform.position, Waypoints[currentPoint].position) < WaypointDistance) 
		{
			EleTime = 0;
			currentPoint++;
		}
		
		if (currentPoint >= Waypoints.Length) 
		{
			currentPoint = 0;
		}
		if(EleTime >= 5)
		{
			transform.position = Vector3.MoveTowards (transform.position, Waypoints [currentPoint].position, moveSpeed * Time.deltaTime);
			//transform.LookAt (Waypoints [currentPoint]);
		}
	}
}
