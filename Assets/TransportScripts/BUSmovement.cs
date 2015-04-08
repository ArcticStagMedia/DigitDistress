using UnityEngine;
using System.Collections;

public class BUSmovement : MonoBehaviour {

	public BoardBus BBmovement;
	public BoardBus BBmovement1;

	public Transform[] Waypoints;
	public float moveSpeed;
	public float BusTime;
	private int currentPoint;

	// Use this for initialization
	void Start () {
		transform.position = Waypoints [0].position;
		currentPoint = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		BusTime += Time.deltaTime;


		if (transform.position == Waypoints [currentPoint].position) 
		{
			BusTime = 0;
			currentPoint++;
		}

		if (currentPoint >= Waypoints.Length) 
		{
			currentPoint = 0;
		}
		if(BusTime >= 7.5)
		{
			transform.position = Vector3.MoveTowards (transform.position, Waypoints [currentPoint].position, moveSpeed * Time.deltaTime);
			transform.LookAt (Waypoints [currentPoint]);
		}
	}
}
