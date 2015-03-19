using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BuildingPlacer : MonoBehaviour {

    private string txtClickU = "Click \"U\" to view Building Interface";
    public Text mainCameraCanvas;
    public GameObject gameCanvas;
    public Camera mainCamera;
    public GameObject player;
    private MouseLook mL;
    private MouseLook mLTwo;
    private CharacterMotor cM;
    private bool inUI = false;
    private bool ableToAccessUI = false;
    
    // Use this for initialization
	void Start () 
    {
        mL = player.GetComponent<MouseLook>();
        mLTwo = mainCamera.GetComponent<MouseLook>();
        cM = player.GetComponent<CharacterMotor>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (ableToAccessUI && Input.GetKeyDown(KeyCode.U))
        {
                gameCanvas.SetActive(true);
                mainCameraCanvas.text = null;
                inUI = true;
        }

        if (inUI)
        {
            mL.enabled = false;
            mLTwo.enabled = false;
            cM.enabled = false;
        }
        else
	    {
            mL.enabled = true;
            mLTwo.enabled = true;
            cM.enabled = true;
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
