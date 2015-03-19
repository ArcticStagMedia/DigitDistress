using UnityEngine;
using System.Collections;

public class RemoveBuilding : MonoBehaviour {

    private GameObject currentBuilding;
    public GameObject buildingPlaceholder;

    // Use this for initialization
	void Start () 
    {
        currentBuilding = transform.Find("B_CoffeeShop").gameObject;
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void RemoveTheBuilding()
    {
        currentBuilding.SetActive(false);
        buildingPlaceholder.SetActive(true);
    }
}
