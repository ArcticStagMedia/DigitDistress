using UnityEngine;
using System.Collections;

public class CameraLockScript : MonoBehaviour 
{

	public static bool CameraLock = false;
	public GameObject TheCamera;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (CameraLock == true) 
		{
			Quaternion currentlocation = TheCamera.transform.rotation;
			Quaternion wantedlocation = Quaternion.Euler(55,0,0);
			TheCamera.transform.rotation = Quaternion.RotateTowards(currentlocation,wantedlocation, Time.deltaTime * 50);
			//TheCamera.transform.localEulerAngles = new Vector3(55,0,0);
		}

		if (Input.GetButtonUp("Jump"))
		{
			CameraLock = !CameraLock;
		}

	}
}
