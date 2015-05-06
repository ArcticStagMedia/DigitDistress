using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

public class CloseMyUI : MonoBehaviour
{

    public GameObject builderSphere;
   
    private Camera mainCamera;
    private UIScript Ui;
    private BuildingPlacer bP;


    // Use this for initialization
    void Start()
    {
        mainCamera = Camera.main;
        Ui = mainCamera.GetComponentInChildren<UIScript>();
        bP = builderSphere.GetComponent<BuildingPlacer>();

        
    }
    // Update is called once per frame
    void Update()
    {

    }

    public void CloseMeNow(bool open)
    {
        Ui.MovementSwitch(open);
        
        bP.CheckUIState(open);
        
    }


}
