using UnityEngine;
using System.Collections;

public class BuildingManager : MonoBehaviour
{

    private int currentActiveBuilding;
    private int defaultBuilding = 0;

    public int DefaultBuilding
    {
        get { return defaultBuilding; }
        private set { defaultBuilding = value; }
    }
    

    public int CurrentActiveBuilding
    {
        get { return currentActiveBuilding; }
        set { currentActiveBuilding = value; }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
