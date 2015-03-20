using UnityEngine;
using System.Collections;

public class PlaceBuilding : MonoBehaviour
{

    private GameObject buildArea;
    public GameObject[] buildings;
    private int buildingSelected;
    private BuildingManager bM;

    // Use this for initialization
    void Start()
    {
        buildArea = transform.Find("BuildingPlacementPlotChild").gameObject;
        bM = GetComponent<BuildingManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BuildBuilding(int buildingID)
    {
        buildArea.SetActive(false);
        bM.CurrentActiveBuilding = buildingID;
        buildings[buildingID].SetActive(true);
    }

    public void DeactivateBuilding(int buildingID)
    {
        buildings[buildingID].SetActive(false);
    }
}
