using UnityEngine;
using System.Collections;

public class InteractSphere : MonoBehaviour 
{
	public GameObject CoffeeShop;
	public GameObject RecordStore;
	public GameObject LanRail;
	public GameObject PlacementSpot;
	public Vector3 PlacementPosition;
	public GameObject CurBuild;
	public GameObject TheCurrentBuiltBuilding;

	// Use this for initialization
	void Start () 
	{

		PlacementPosition = PlacementSpot.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{

	}


	void OnInteract ()
	{

	}


	public void BuildBuilding(int BuildID)
	{
		if (CurBuild != null)
		{
			TheCurrentBuiltBuilding.SendMessage("Destroy");
		}

		if (BuildID == 1)
		{
			CurBuild = CoffeeShop;
		}
		if (BuildID == 3)
		{
			CurBuild = LanRail;
		}
		if (BuildID == 2)
		{
			CurBuild = RecordStore;
		}


		TheCurrentBuiltBuilding = Instantiate (CurBuild, new Vector3 (PlacementPosition.x, PlacementPosition.y, PlacementPosition.z),Quaternion.identity ) as GameObject;

	}
}

