using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BuildingUIScript : MonoBehaviour 
{
	public GameObject MainMenu;
	public GameObject BuildingType;
	public GameObject TransportPanel;
	public GameObject EntertainmentPanel;
	private UIScript UiScript;


	// Use this for initialization
	void Start ()
	{
		UiScript = Camera.main.GetComponent<UIScript>();
		MainMenu.SetActive (false);
		BuildingType.SetActive (false);
		TransportPanel.SetActive (false);
		EntertainmentPanel.SetActive (false);
	
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void CloseAll()
	{
		MainMenu.SetActive (false);
		BuildingType.SetActive (false);
		TransportPanel.SetActive (false);
		EntertainmentPanel.SetActive (false);
		UiScript.MovementSwitch (false);

	}

	public void SetTransport()
	{
		MainMenu.SetActive (false);
		BuildingType.SetActive (false);
		TransportPanel.SetActive (true);
		EntertainmentPanel.SetActive (false);
	}

	public void SetEntertainment()
	{
		MainMenu.SetActive (false);
		BuildingType.SetActive (false);
		TransportPanel.SetActive (false);
		EntertainmentPanel.SetActive (true);

	}
	public void SetMain()
	{
		MainMenu.SetActive (true);
		BuildingType.SetActive (false);
		TransportPanel.SetActive (false);
		EntertainmentPanel.SetActive (false);
	}

	public void SetBuildingTypePanel()
	{
		MainMenu.SetActive (false);
		BuildingType.SetActive (true);
		TransportPanel.SetActive (false);
		EntertainmentPanel.SetActive (false);
	}
}
