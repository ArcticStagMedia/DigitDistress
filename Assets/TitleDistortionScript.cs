using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TitleDistortionScript : MonoBehaviour 
{
	public GameObject TitleNormal;
	public GameObject TitleCorrupted;
	public bool Corruption = true;


	// Use this for initialization
	void Start () 
	{
		StartCoroutine (Distortion ());
		Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () 
	{

	
	}

	public IEnumerator Distortion()
	{
		TitleCorrupted.SetActive (Corruption);
		TitleNormal.SetActive (!Corruption);
		int i = Random.Range (0, 2);
		Corruption = !Corruption;
		yield return new WaitForSeconds (i);
		StartCoroutine (Distortion ());
	}
}
