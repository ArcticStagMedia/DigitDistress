using UnityEngine;
using System.Collections;

public class SphereUI : MonoBehaviour 
{
	public GameObject target;
	public GameObject Text;
	public bool CanBuild;

	// Use this for initialization
	void Start ()
	{
		target = GameObject.FindGameObjectWithTag("Player");

	
	}
	
	// Update is called once per frame
	void Update ()
	{
		Vector3 test = transform.position - target.transform.position;
		transform.rotation = Quaternion.LookRotation(new Vector3(test.x,0,test.z));	
		Screen.lockCursor = true;

	}

	
}
