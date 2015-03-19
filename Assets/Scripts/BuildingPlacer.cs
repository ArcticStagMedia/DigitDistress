using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BuildingPlacer : MonoBehaviour {

    private string txtClickU = "Click \"U\" to view Building Interface";
   
    public GameObject gameCanvas;
    public Camera mainCamera;
    public GameObject player;
    private MouseLook mL;
    private MouseLook mLTwo;
    private CharacterMotor cM;
    private Text mainCameraCanvas;
    private bool inUI = false;
    private bool ableToAccessUI = false;
    private UIScript Ui;
    private Quaternion myLocation;
    
    // Use this for initialization
	void Start () 
    {
        player = GameObject.FindGameObjectWithTag("Player");
        mainCamera = Camera.main;
        mainCameraCanvas = mainCamera.GetComponentInChildren<Text>();
        mL = player.GetComponent<MouseLook>();
        mLTwo = mainCamera.GetComponent<MouseLook>();
        cM = player.GetComponent<CharacterMotor>();
        Ui = player.GetComponentInChildren<UIScript>();
        myLocation = this.transform.rotation;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (ableToAccessUI && Input.GetKeyDown(KeyCode.U))
        {
                gameCanvas.SetActive(true);
                mainCameraCanvas.text = null;
                Ui.MovementSwitch(true);
                Ui.SetLookDirection(myLocation);
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            mainCameraCanvas.text=txtClickU;
            ableToAccessUI = true;
        }
    }

    void OnTriggerExit(Collider other)
    {     
            mainCameraCanvas.text = null;
            ableToAccessUI = false;
    }
}
