using UnityEngine;
using System.Collections;

public class Elevator : MonoBehaviour {
	//THE BOTTOM TRIGGER WHEN ELEVATOR HAS REACHED BOTTOM
	public Transform Bottom;
	//TOP TRIGGER
	public Transform Top;
	//HOW LONG THE ELEVATOR SLEEPS AFTER DESTINATION IS REACHED
	public float BreakTime=1.5f;
	//SPEED THE ELEVATOR MOVES
	public float Speed=5;
	//ENABLES SIDEWAYS MOVEMENT OF THE ELEVATOR
	public bool moveside;
	//WHEN CURRENTLY ASENDING
	public bool asend;
	//WHEN CURRENTLY DESENDING
	public bool decend;
	//IS MOVING
	public bool Moving;
	//TIMER
	public float timer;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		//START TIMER
		timer+=Time.deltaTime;
		
		//WHEN THE TIMER IS PAST ITS BREAK TIME
		if(timer>BreakTime){
			Moving=true;
			
			//MOVEMENT
	if(asend){
				if(moveside){
				transform.position += transform.right * Speed * Time.deltaTime;	
				}
				else{
	transform.position += transform.up * Speed * Time.deltaTime;
				}
		}
		
		if(decend){
				if(moveside){
				transform.position += transform.right * -Speed * Time.deltaTime;	
				}
				else{
	transform.position += transform.up * -Speed * Time.deltaTime;
				}
		}
		}
		else Moving=false;
		
	}
	void OnTriggerEnter(Collider other){
		//IF HITS BOTTOM ASEND
		if(other.transform==Bottom){
			asend=true;
			decend=false;
			timer=0;
		}
		//IF HITS TOP DESEND
		if(other.transform==Top){
			decend=true;
			asend=false;
			timer=0;
		}
	}
}
