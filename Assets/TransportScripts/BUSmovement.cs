using UnityEngine;
using System.Collections;

public class BUSmovement : MonoBehaviour {

	public Transform[] BusWaypoints;
	public float BusmoveSpeed;
	public float BusTime;
	private int BuscurrentPoint;
	
	// Use this for initialization
	void Start () {
		transform.position = BusWaypoints [0].position;
		BuscurrentPoint = 0;
		BusTime = 0f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		BusTime += Time.deltaTime;
		
		
		if (transform.position == BusWaypoints [BuscurrentPoint].position) 
		{
			BusTime = 0f;
			BuscurrentPoint++;
			transform.LookAt (BusWaypoints [BuscurrentPoint]);
			//BusTime = 0;
		}
		
		if (BuscurrentPoint >= BusWaypoints.Length) 
		{
			BuscurrentPoint = 0;
		}
		if(BusTime >= 2)
		{
			transform.position = Vector3.MoveTowards (transform.position, BusWaypoints [BuscurrentPoint].position, BusmoveSpeed * Time.deltaTime);
			//transform.LookAt (Waypoints [currentPoint]);
		}
	}
}