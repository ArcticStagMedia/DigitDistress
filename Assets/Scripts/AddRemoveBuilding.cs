using UnityEngine;
using System.Collections;

public class AddRemoveBuilding : MonoBehaviour
{

    private GameObject buildArea;
    public GameObject[] buildings;
    private int buildingSelected;
    private BuildingManager bM;
    private int currentBuilding;

    // Use this for initialization
    void Start()
    {
        buildArea = transform.Find("BuildingPlacementPlotChild").gameObject;
        bM = GetComponent<BuildingManager>();
    }

    // Update is called once per frame
    void Update()
    {
        currentBuilding = bM.CurrentActiveBuilding;
    }

    public void BuildBuilding(int buildingID)
    {
        bM.CurrentActiveBuilding = buildingID;
        buildings[buildingID].SetActive(true);
    }

    public void DeactivateBuilding(int buildingID)
    {
        buildings[buildingID].SetActive(false);
    }

    public void RemoveTheBuilding()
    {
        DeactivateBuilding(currentBuilding);
    }

    public void PlaceDefaultBuilding()
    {
        bM.CurrentActiveBuilding = 0;
        buildings[0].SetActive(true);
    }
}
