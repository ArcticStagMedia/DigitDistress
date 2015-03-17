using UnityEngine;
using System.Collections;

public class GuiTextScript : MonoBehaviour 
{

	public Vector3 Test;
	public float X;
	public float Y;
	public float Z;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		Test = (Camera.main.WorldToScreenPoint(this.transform.position));
		X = Test.x;
		Y = Test.y;
		Z = Test.z;
	}

	void OnGui ()
	{
		GUI.Label (new Rect (Screen.height - Y, Screen.width - X, 0, 0), "Test");

	}
}
