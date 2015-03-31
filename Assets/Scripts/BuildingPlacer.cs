using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BuildingPlacer : MonoBehaviour
{

    private string txtClickU = "Click \"U\" to view Building Interface";

    public GameObject gameCanvas;
    public Camera mainCamera;
    public GameObject player;
    private Text mainCameraCanvas;
    private bool inUI = false;
    private bool ableToAccessUI = false;
    private UIScript Ui;
    private Quaternion myLocation;
    public Button btnPlaceBuilding;
    private bool buildingPlaced = false;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        mainCamera = Camera.main;
        mainCameraCanvas = mainCamera.GetComponentInChildren<Text>();
        Ui = player.GetComponentInChildren<UIScript>();
        myLocation = this.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (ableToAccessUI && Input.GetKeyDown(KeyCode.U))
        {
            gameCanvas.SetActive(true);
            inUI = true;
            mainCameraCanvas.text = null;
            Ui.MovementSwitch(true);
            Ui.SetLookDirection(myLocation);

        }

        if (buildingPlaced)
        {
            btnPlaceBuilding.interactable = false;
        }
        else
        {
            btnPlaceBuilding.interactable = true;
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            mainCameraCanvas.text = txtClickU;
            ableToAccessUI = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        mainCameraCanvas.text = null;
        ableToAccessUI = false;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && !inUI)
        {
            mainCameraCanvas.text = txtClickU;
        }
    }

    public void CheckUIState(bool amIInUI)
    {
        inUI = amIInUI;
    }

    public void BuildingWasPlaced(bool placedBuilding)
    {
        buildingPlaced = placedBuilding;
    }
}
