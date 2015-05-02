using UnityEngine;
using System.Collections;

public class TrainBuildingUIScript : MonoBehaviour 
{
	public GameObject MainPanel;
	public GameObject TrainBuildPanel;
	public GameObject ConfirmPanel;
	private UIScript UiScript;

	// Use this for initialization
	void Start ()
	{
		UiScript = Camera.main.GetComponent<UIScript>();
		MainPanel.SetActive (false);
		TrainBuildPanel.SetActive (false);
		ConfirmPanel.SetActive (false);
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void closeall()
	{
		MainPanel.SetActive (false);
		TrainBuildPanel.SetActive (false);
		ConfirmPanel.SetActive (false);

	}

	public void ShowMain()
	{
		MainPanel.SetActive (true);
		TrainBuildPanel.SetActive (false);
		ConfirmPanel.SetActive (false);
	}

	public void ShowBuildTrain ()
	{
		MainPanel.SetActive (false);
		TrainBuildPanel.SetActive (true);
		ConfirmPanel.SetActive (false);
	}

	public void ShowConfirm()
	{
		MainPanel.SetActive (false);
		TrainBuildPanel.SetActive (false);
		ConfirmPanel.SetActive (true);
	}
}
