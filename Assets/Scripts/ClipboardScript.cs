using UnityEngine;
using System.Collections;

public class ClipboardScript : MonoBehaviour 
{
	public static bool clipboard = false;

	public Vector3 UpPos;
	public Vector3 DownPos;
	public Quaternion DownRotation;
	public Quaternion UpRotation;

	public float TimeTakenDuringLerp = 1f;
	public float DistanceToMove = 10;
	private bool WeLerping = false;

	private float TimeLerpingBegan;
	public bool CanLerp = true;
	public GameObject TheCamera;
	public Quaternion CameraStart;
	public Quaternion CameraEnd;
	public Quaternion CameraForClip;
	public Quaternion CameraNormal;
	public static bool LockCamera;


	// Use this for initialization
	void Start () 
	{
		DownPos = transform.localPosition;
		DownRotation = transform.localRotation;
		UpPos = new Vector3 (-0.119f, 1.3f, 1.5f);
		UpRotation = Quaternion.Euler (90, -180, 0);
		CameraForClip = Quaternion.Euler (0, 0, 0);

	
	}
	
	// Update is called once per frame
	void Update ()
	{
		CameraNormal = TheCamera.transform.localRotation;

		if (Input.GetKeyUp(KeyCode.Q) & CanLerp) 
		{
			StartTheLerp();
			clipboard = !clipboard;
			CanLerp = false;
		}

	}

	void SetCameraLocation()
	{
		CameraStart = CameraNormal;

	}

	void StartTheLerp()
	{
		WeLerping = true;
		TimeLerpingBegan = Time.time;
		if (!clipboard) 
		{
			LockingTheCam();
		}




	}

	IEnumerator LockingTheCam()
	{
		LockCamera = !LockCamera;
		SetCameraLocation();
		return null;
	}

	void FixedUpdate()
	{
		if (WeLerping) 
		{
			if(clipboard)
			{


				float TimeSinceWeStartedLerping = Time.time - TimeLerpingBegan;
				float PercentageComplete = TimeSinceWeStartedLerping / TimeTakenDuringLerp;


				transform.localPosition = Vector3.Lerp (DownPos, UpPos, PercentageComplete);
				transform.localRotation = Quaternion.Lerp(DownRotation,UpRotation, PercentageComplete);
				TheCamera.transform.localRotation = Quaternion.Lerp(CameraStart,CameraForClip,PercentageComplete);

				if (PercentageComplete >= 1.0f) 
				{
					WeLerping = false;
					CanLerp = true;
					GUIScript.CanvasActive = true;

				}
			}

			if(!clipboard)
			{
				GUIScript.CanvasActive = false;
				float TimeSinceWeStartedLerping = Time.time - TimeLerpingBegan;
				float PercentageComplete = TimeSinceWeStartedLerping / TimeTakenDuringLerp;
					
				transform.localPosition = Vector3.Lerp (UpPos,DownPos, PercentageComplete);
				transform.localRotation = Quaternion.Lerp(UpRotation,DownRotation, PercentageComplete);
				TheCamera.transform.localRotation = Quaternion.Lerp(CameraForClip,CameraStart,PercentageComplete);

				if (PercentageComplete >= 1.0f) 
				{
					WeLerping = false;
					CanLerp = true;
					LockingTheCam();

				}
			}

		}
	}


}
