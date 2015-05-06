using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class BuildingManager
{
	public static List<GameObject> m_lBuildingPrefabs = new List<GameObject> ();


	public static GameObject getBuilding(string name)
	{
		return m_lBuildingPrefabs.Find (x => x.name == name);
		}
    
	public static void setAllowedBuildings(List<GameObject> allowedBuildings)
	{
		m_lBuildingPrefabs.AddRange (allowedBuildings);
		}
}
