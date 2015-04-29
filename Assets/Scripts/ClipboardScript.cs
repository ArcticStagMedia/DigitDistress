using UnityEngine;
using System.Collections;

public class ClipboardScript : MonoBehaviour 
{
	public static bool clipboard = false;

	public Vector3 UpPos;
	public Vector3 DownPos;
    public Vector3 upSize;
    public Vector3 downSize;
	public Quaternion DownRotation;
	public Quaternion UpRotation;

	public float TimeTakenDuringLerp = 1f;
	public float DistanceToMove = 10;
	private bool WeLerping = false;

    public GameObject playerbody;

	private float TimeLerpingBegan;
	public bool CanLerp = true;
	public GameObject TheCamera;
	public Quaternion CameraStart;
	public Quaternion CameraEnd;
	public Quaternion CameraForClip;
	public Quaternion CameraNormal;
	public static bool LockCamera = false;
    private bool lockMovement = true;

    private MouseLook mL;
    private MouseLook mL2;
    private CharacterMotor cM;


	// Use this for initialization
	void Start () 
	{
		Screen.lockCursor = true;
        mL = playerbody.GetComponent<MouseLook>();
        mL2 = TheCamera.GetComponentInChildren<MouseLook>();
        cM = playerbody.GetComponent<CharacterMotor>();
		DownPos = transform.localPosition;
		DownRotation = transform.localRotation;
		UpRotation = Quaternion.Euler (90, -180, 0);
		CameraForClip = Quaternion.Euler (0, 0, 0);

	
	}
	
	// Update is called once per frame
	void Update ()
	{
		CameraNormal = TheCamera.transform.localRotation;

		if (Input.GetKeyUp(KeyCode.Mouse1) & CanLerp) 
		{
			StartTheLerp();
			clipboard = !clipboard;
			CanLerp = false;
			Screen.lockCursor = !Screen.lockCursor;
		}

	}

	void StartTheLerp()
	{
		WeLerping = true;
		TimeLerpingBegan = Time.time;
		if (!clipboard) 
		{
            lockPlayerPosition();
		}




	}

	void SetCameraLocation()
	{
		CameraStart = CameraNormal;
		
	}

    void lockPlayerPosition()
    {
        lockMovement = !lockMovement;
        mL.enabled = lockMovement;
        mL2.enabled = lockMovement;
        cM.enabled = lockMovement;
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
                transform.localScale = Vector3.Lerp(downSize, upSize, PercentageComplete);
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
                transform.localScale = Vector3.Lerp(upSize, downSize, PercentageComplete);
				transform.localRotation = Quaternion.Lerp(UpRotation,DownRotation, PercentageComplete);
				TheCamera.transform.localRotation = Quaternion.Lerp(CameraForClip,CameraStart, PercentageComplete);

				if (PercentageComplete >= 1.0f) 
				{
					WeLerping = false;
					CanLerp = true;
                    lockPlayerPosition();

				}
			}

		}
	}


}
