using UnityEngine;
using System.Collections;

public class RemoveBuilding : MonoBehaviour
{

    private int currentBuilding;
    private BuildingManager bM;
    private PlaceBuilding pB;
    public GameObject buildingPlaceholder;

    // Use this for initialization
    void Start()
    {
        bM = GetComponent<BuildingManager>();
        pB = GetComponent<PlaceBuilding>();
    }

    // Update is called once per frame
    void Update()
    {
        currentBuilding = bM.CurrentActiveBuilding;
    }

    public void RemoveTheBuilding()
    {
        pB.BuildBuilding(bM.DefaultBuilding);
        pB.DeactivateBuilding(currentBuilding);
    }
}
