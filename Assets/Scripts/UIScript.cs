using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIScript : MonoBehaviour 
{

    public Camera mainCamera;
    public GameObject player;
    private MouseLook mL;
    private MouseLook mLTwo;
    private CharacterMotor cM;
    private Text mainCameraCanvas;

	// Use this for initialization
	void Start () 
	{
        player = GameObject.FindGameObjectWithTag("Player");
        mainCamera = Camera.main;
        mainCameraCanvas = mainCamera.GetComponentInChildren<Text>();
        mL = player.GetComponent<MouseLook>();
        mLTwo = mainCamera.GetComponent<MouseLook>();
        cM = player.GetComponent<CharacterMotor>();
	}
	
	// Update is called once per frame
	void Update () 
	{
	}

    public void MovementSwitch(bool inUI)
    {
            mL.enabled = !inUI;
            mLTwo.enabled = !inUI;
            cM.enabled = !inUI;
    }

    public void SetLookDirection(Quaternion lookDirection)
    {
        mainCamera.transform.rotation = lookDirection;
    }
}
