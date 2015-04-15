using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour
{
    //private GameController gameController;
    private GameObject gameControllerObject;

	public List<GameObject> m_lAllowedBuildings;

    public float money;        

    // Use this for initialization
    void Start()
    {
		if (BuildingManager.m_lBuildingPrefabs.Capacity == 0)
		{
			BuildingManager.setAllowedBuildings(m_lAllowedBuildings);
		}
        gameControllerObject = this.gameObject;
        //gameController = gameControllerObject.GetComponent<GameController>();
        money = 10000;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public float GetMoney()
    {
        return money;
    }

    public void SetMoney(float mny)
    {
        money = money + mny;
    }
}
