using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BuildingPlacer : MonoBehaviour {

    private string txtClickU = "Click \"U\" to view Building Interface";
    public Text mainCameraCanvas;
    public GameObject gameCanvas;
    public Camera mainCamera;
    private bool ableToAccessUI = false;
    
    // Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update ()
    {
        if (ableToAccessUI && Input.GetKeyDown(KeyCode.U))
        {
                gameCanvas.SetActive(true);
                mainCameraCanvas.text = null;
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
