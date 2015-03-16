using UnityEngine;
using System.Collections;

public class BuildingController : MonoBehaviour {

    public string itemSold;
    public int itemCost;
    public int digitsInside = 0;
    public int capacity = 9999;

    private GameObject gameControllerObject;
    private GameController gameController;


	// Use this for initialization
	void Start () 
    {
        gameControllerObject = GameObject.FindGameObjectWithTag("GameController");
        gameController = gameControllerObject.GetComponent<GameController>();
	}
	
	// Update is called once per frame
	void Update () 
    {
	    if (digitsInside!=0)
        {
            for (digitsInside = digitsInside; digitsInside > 0; digitsInside--)
            {
                gameController.recourceMoney += itemCost;
            }
        }
	}
}
