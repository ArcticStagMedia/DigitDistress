using UnityEngine;
using System.Collections;

public class BUSmovement : MonoBehaviour {

	public BoardBus BBmovement;
	public BoardBus BBmovement1;

	public Transform[] Waypoints;
	public float moveSpeed;
	private int currentPoint;

	// Use this for initialization
	void Start () {
		transform.position = Waypoints [0].position;
		currentPoint = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.LookAt (Waypoints [currentPoint]);


		if (transform.position == Waypoints [currentPoint].position) 
		{

			currentPoint++;
		}

		if (currentPoint >= Waypoints.Length) 
		{
			currentPoint = 0;
		}
		if(BBmovement.CountAI == 6)
		{
			transform.position = Vector3.MoveTowards (transform.position, Waypoints [currentPoint].position, moveSpeed * Time.deltaTime);
		}
		if(BBmovement1.CountAI == 6)
		{
			transform.position = Vector3.MoveTowards (transform.position, Waypoints [currentPoint].position, moveSpeed * Time.deltaTime);
		}
	}
}
