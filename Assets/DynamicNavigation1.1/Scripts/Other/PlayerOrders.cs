using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerOrders : MonoBehaviour {
	public Transform AIToOrder;
	public List<Transform> AIsToOrder;
	public Transform cam;
	public Transform Targ;
	public Transform Indicator;
	private bool LocationOrder;
	public bool EnableTips=true;
	
	// Use this for initialization
	void Start () {
		for (int i = 0; i < AIsToOrder.Count; i++){
		RandomPath ex=(RandomPath)AIsToOrder[i].GetComponent("RandomPath");
	ex.enabled=false;
		AIMove ai=(AIMove)AIsToOrder[i].GetComponent("AIMove");
		ai.DistanceStop=3.5f;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		//WITH THIS NAVIGATION ENGINE, ORDERS BECOME SUPER SIMPLE
		
		//ASK IF THE AI TO ORDER EXISTS
		if(AIsToOrder.Count>0){
			for (int i = 0; i < AIsToOrder.Count; i++){
			//GET COMPONENT OF THE SIMPLE AI SCRIPT
		AIMove ai=(AIMove)AIsToOrder[i].GetComponent("AIMove");
			RandomPath ex=(RandomPath)AIsToOrder[i].GetComponent("RandomPath");
			if(ai){
				//IF 1 IS PRESSED THE TARGET BECOMES YOURSELF
			if(Input.GetKeyUp(KeyCode.Alpha1)){	
			ai.Target=transform;
					ai.DistanceStop=3.5f;
					ex.enabled=false;
			}
				//IF 2 IS PRESSED ORDER TO LOCATION IS ENABLED
			if(Input.GetKeyUp(KeyCode.Alpha2)){
					LocationOrder=true;
					
					
				}
				
				if(Input.GetKeyUp(KeyCode.Alpha3)){
					ex.enabled=true;
					LocationOrder=false;
					ai.DistanceStop=0f;
					ex.Proceed=true;
				}
				
				
				//ORDERING TO LOCATION
				
				//FIRST CHECK IF THE CAM EXISTS
				if(LocationOrder&cam){
					
					RaycastHit hit = new RaycastHit();
					//SHOHOT RAYCAST FROM CENTER OF SCREEN FOREWARD
			if(Physics.Raycast(cam.position, cam.TransformDirection(Vector3.forward), out hit, 1000, 15)){
					if(Indicator){
							//ENABLE RENDER OF INDICATOR AND POSITION ON THE POINT OF RAYCAST
						Indicator.renderer.enabled=true;
								Vector3 hpoint=hit.point;
								hpoint.y=hpoint.y+0.5f;
							Indicator.position=hpoint;
							
						}
						
					}
					
					
					}
					}
					
				}
				
				
				
			}
		//E CONFIRMS ORDER
		if(AIsToOrder.Count>0){
			
		if(LocationOrder&cam){
					if(Input.GetKeyUp(KeyCode.E)){
					for (int i = 0; i < AIsToOrder.Count; i++){
						AIMove ai=(AIMove)AIsToOrder[i].GetComponent("AIMove");
						RandomPath ex=(RandomPath)AIsToOrder[i].GetComponent("RandomPath");
						if(Indicator){
								ex.enabled=false;
							Indicator.renderer.enabled=false;
						GridPosition gp=(GridPosition)Indicator.GetComponent("GridPosition");
						if(gp){
						ex.enabled=false;
						Targ.position=gp.CurrentWaypointVec;
						ai.Target=Targ;
						
									ai.DistanceStop=2f;
							}
				
						}
					}
					LocationOrder=false;
				}
				
			}
		
			
		}
	}
	void OnGUI(){
		if(EnableTips){
	GUI.Label(new Rect(0, 10, 300, 26), "Press 1 to order units to follow you");
	GUI.Label(new Rect(0, 30, 500, 26), "Press 2 to order units to specified location(E to confirm)");
	GUI.Label(new Rect(0, 50, 300, 26), "Press 3 to order units to explore environment");
			
		}
		
	}
}
