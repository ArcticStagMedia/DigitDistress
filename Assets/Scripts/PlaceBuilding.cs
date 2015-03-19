using UnityEngine;
using System.Collections;

public class PlaceBuilding : MonoBehaviour
{

    private GameObject buildArea;
    public GameObject building;

    // Use this for initialization
    void Start()
    {
        building.SetActive(false);
        buildArea = transform.Find("BuildingPlacementPlotChild").gameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BuildBuilding()
    {
        buildArea.SetActive(false);
        building.SetActive(true);
    }
}
