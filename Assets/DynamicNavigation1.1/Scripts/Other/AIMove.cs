using UnityEngine;
using System.Collections;

public class AIMove : MonoBehaviour {
	//THE TARGET TO FOLLOW
	public Transform Target;
	//DISTANCE BEFORE AI STOPS
	public float DistanceStop=4;
	//ENABLES GOTO TARGET
	public bool GotoTarget;
	//THE CHARACTER CHOOSEN FOR AI
	public Transform CharacterToAnimate;
	//ANIMATIONS
	public AnimationClip Run;
	public AnimationClip Idle;
	public float RunSpeed=5;
	
	public bool EnableSimpleObstacleAvoid=true;
	public string ObstacleTag="obstacle";
	private Transform CharacterToAvoid;
	private bool Avoiding;
	private float atime;
	//ELEVATOR INFO FOR INTERACTION
	public Transform ElevBottom;
	public Transform ElevCent;
	public Transform ElevTop;
	public Transform Elevator;
	public bool ElevWait;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Avoiding){
		atime+=Time.deltaTime;
			if(atime>0.2f){
				Avoiding=false;
				atime=0;
				
			}
		}
		
		//HERE IS THE SMALL AMOUNT OF CODE FOR INPUTING THE TARGET TO THE NAVIGATOR SCRIPT, AND THEN FOLLOWING THE PATH
		
		//START GOTO TARGET
		if(GotoTarget&Target){
			//GET COMPONENT OF NAVIGATOR SCRIPT
		Navigator nav=(Navigator)GetComponent("Navigator");
			//ASSIGN THE TARGET TO THE NAVIGATOR SCRIPT(FIRST ASKING IF HE ALREADY HAS)
		if(nav.Target!=Target)nav.Target=Target;
			
			//NOW LETS TELL THE NAVIGATOR SCRIPT TO NAVIGATE THE TARGET WE ASSIGNED
			if(nav.NavigateTarget){}else nav.NavigateTarget=true;
			
			//DETECT DISTANCE FROM TARGET FOR STOPPING
			float dist=Vector3.Distance(Target.position, transform.position);
			
			
			//HERE IS AN IMPORTANT PIECE.  BEFORE WE GO AHEAD AND START RUNNING DOWN THE PATH, WE NEED TO MAKE SURE THE NAVIGATOR
			//ACTUALLY HAS A PATH.  NAV.SLOWTOSTOP IS A COMMAND GIVEN TO THE AI THAT THERE IS EITHER NO WAY TO THE TARGET, OR A WAY HAS NOT
			//YET BEEN FOUND.
			
			//THE OTHER REASONS FOR THE AI TO STOP ARE, WAITING FOR THE ELEVATOR, OR IN RANGE OF HIS TARGET
			
			if(nav.SlowToStop|ElevWait|dist<DistanceStop){
				
				//IDLE STATE IF AI HAS BEEN COMMANDED TO STOP
			if(CharacterToAnimate&Idle){
			CharacterToAnimate.animation.CrossFade(Idle.name, .1f);
			}	
			}
			else{
				
				//RUN STATE WHEN A PATH HAS BEEN GIVIN
			if(CharacterToAnimate&Run){
			CharacterToAnimate.animation.CrossFade(Run.name, .1f);
			}
			
				
				//HERE TELL THE AI TO TURN TO THE CURRENT WAYPOINT THE NAVIGATOR SCRIPT IS TELLING US TO.  NAV.CURRENTTARGETWAYPOINT
				
				if(Avoiding&CharacterToAvoid){
	transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(transform.position - CharacterToAvoid.position), 2 * Time.deltaTime);					
				}
				else{
		transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(nav.CurrentTargetWaypoint - transform.position), 7 * Time.deltaTime);		
				}
					transform.position += transform.forward * RunSpeed * Time.deltaTime;
				
				//MAKE SURE CHARACTER DOES NOT FALL OVER
				transform.eulerAngles = new Vector3(0,transform.eulerAngles.y,0);
			}
			
		}
		
	
	}
	
	//THIS SECTION DEALS WITH THE ELEVATOR SCRIPT
	void OnTriggerStay(Collider other){
		
		//FIRST ASKS IF THE TRIGGER IS COLLIDING WITH AND OR THE ELEVATOR TRIGGERS
		if(ElevTop&ElevBottom&Elevator){
		
			//GET THE COMPONENT OF THE ELEVATOR
		Elevator el=(Elevator)Elevator.GetComponent("Elevator");	
		
			//IF AI IS COLLIDING WITH TOP OF ELEVATOR, WAIT UNTIL IT IS NOT MOVING AND ABOUT TO ASCEND BEFORE BOARDING
			if(other.transform==ElevTop){
				if(el.decend){
				if(el.Moving)ElevWait=true;
					else{
					ElevWait=false;	
				}
				}
				else ElevWait=true;
			}
			
			//SAME FOR THE BOTTOM OF THE ELEVATOR
			if(other.transform==ElevBottom){
				if(el.asend){
				if(el.Moving)ElevWait=true;
					else{
					ElevWait=false;	
				}
				}
				else ElevWait=true;
			}
			
			//ONCE AI HAS BOARDED, STAY PUT UNTIL REACHES DESTINATION
			if(other.transform==ElevCent){
				if(el.moveside){}
				else{
				if(el.asend){
		transform.position += transform.up * el.Speed * Time.deltaTime;
				}
				}
				
			if(el.Moving)ElevWait=true;
					else{
					ElevWait=false;	
				}	
			}
	
		
		}
	}
	void OnCollisionEnter(Collision other){
		if(other.transform.tag==ObstacleTag){
			Avoiding=true;
			CharacterToAvoid=other.transform;
			
		}
		
	}
	
}
