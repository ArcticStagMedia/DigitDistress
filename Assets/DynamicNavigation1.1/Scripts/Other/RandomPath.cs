using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RandomPath : MonoBehaviour {
	//LIST OF TARGETS
	public List<Transform> Targets;
	//THE CURRENT TARGET
	public Transform CurrentTarget;
	//RANDOM NUMBER
	public int RAN;
	
	public bool Proceed;
	
	// Use this for initialization
	void Start () {
		
		//LETS RANDOMLY SELECT A NUMBER AT THE START
	if(Targets.Count>0){
			//GENERATE RANDOM NUMBER
		RAN=(int)((Random.value)*Targets.Count);
			//GET AI COMPONENT
		AIMove ai=(AIMove)GetComponent("AIMove");
			//ASSIGN NEW TARGET FROM LIST WITH RANDOM NUMBER
			CurrentTarget=Targets[RAN];
			ai.Target=Targets[RAN];
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Proceed){
			AIMove ai=(AIMove)GetComponent("AIMove");	
			CurrentTarget=Targets[RAN];
			ai.Target=Targets[RAN];
			Proceed=false;
		}
	
	}
	void OnTriggerStay(Collider other){
		//WHEN A TRIGGER WITH THE CURRENT TARGET HAPPENS, RANDOMLY SELECT A NEW
		if(other.transform==CurrentTarget){
		RAN=(int)((Random.value)*Targets.Count);
			if(Targets[RAN]==CurrentTarget)RAN=(int)((Random.value)*Targets.Count);
			if(Targets[RAN]==CurrentTarget)RAN=(int)((Random.value)*Targets.Count);
			if(Targets[RAN]==CurrentTarget)RAN=(int)((Random.value)*Targets.Count);
			if(Targets[RAN]==CurrentTarget)RAN=(int)((Random.value)*Targets.Count);
		
			Proceed=true;
		}
	}
}
