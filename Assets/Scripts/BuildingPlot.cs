using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BuildingPlot : MonoBehaviour
{

    //private static BuildingManager m_BuildingMananger;
	private GameObject m_CurrentBuilding = null;
	public GameObject PlaceBuildingButton;


    // Use this for initialization
    void Start()
    {
		//
    }

    // Update is called once per frame
    void Update()
    {
        //
    }

    public void BuildBuilding(string buildingName)
    {
		if (m_CurrentBuilding == null) 
		{
			m_CurrentBuilding = (GameObject)(GameObject.Instantiate (BuildingManager.getBuilding (buildingName), this.transform.position, this.transform.rotation));
		}
		if (m_CurrentBuilding != null)
		{
			PlaceBuildingButton.SetActive(false);
		}
    }


    public void RemoveBuilding()
    {
		GameObject.Destroy (m_CurrentBuilding);
		PlaceBuildingButton.SetActive(true);
    }

	public void ReplaceBuilding(string buildingName)
	{
		RemoveBuilding ();
		BuildBuilding (buildingName);
		}

}
