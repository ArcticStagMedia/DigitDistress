using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GUIScript : MonoBehaviour 
{
	public GameObject TheCanvas;
	public static bool CanvasActive = false;
	public GameObject[] Buttons;
	public GameObject ObjectivesPanel;
	public GameObject PanelFastTravel;
	public GameObject FinancesPanel;
	public GameObject ArchivePanel;

	// Use this for initialization
	void Start () 
	{

		Buttons = GameObject.FindGameObjectsWithTag ("Button");

	
	}
	
	// Update is called once per frame
	void Update ()
	{
		/*
		if (CanvasActive == true) 
		{
			//GetComponent<Canvas>().enabled = true;
			foreach(GameObject MyButton in Buttons)
				MyButton.GetComponent<Button>().interactable = true;

		}

		if( CanvasActive == false)
		{
			//GetComponent<Canvas>().enabled =false;
			foreach(GameObject MyButton in Buttons)
				MyButton.GetComponent<Button>().interactable = false;
		}
*/
	
	}


	public void SetPanelHome()
	{
		PanelFastTravel.GetComponent<Canvas> ().enabled = false;
		PanelFastTravel.GetComponent<CanvasGroup> ().blocksRaycasts = false;
		FinancesPanel.GetComponent<Canvas> ().enabled = false;
		FinancesPanel.GetComponent<CanvasGroup> ().blocksRaycasts = false;
		ArchivePanel.GetComponent<Canvas> ().enabled = false;
		ArchivePanel.GetComponent<CanvasGroup> ().blocksRaycasts = false;
		ObjectivesPanel.GetComponent<Canvas> ().enabled = true;
		ObjectivesPanel.GetComponent<CanvasGroup> ().blocksRaycasts = true;


	}

	public void SetPanelFastTravel()
	{
		PanelFastTravel.GetComponent<Canvas> ().enabled = true;
		PanelFastTravel.GetComponent<CanvasGroup> ().blocksRaycasts = true;
		FinancesPanel.GetComponent<Canvas> ().enabled = false;
		FinancesPanel.GetComponent<CanvasGroup> ().blocksRaycasts = false;
		ArchivePanel.GetComponent<Canvas> ().enabled = false;
		ArchivePanel.GetComponent<CanvasGroup> ().blocksRaycasts = false;
		ObjectivesPanel.GetComponent<Canvas> ().enabled = false;
		ObjectivesPanel.GetComponent<CanvasGroup> ().blocksRaycasts = false;

	}
	public void SetPanelArchive()
	{
		PanelFastTravel.GetComponent<Canvas> ().enabled = false;
		PanelFastTravel.GetComponent<CanvasGroup> ().blocksRaycasts = false;
		FinancesPanel.GetComponent<Canvas> ().enabled = false;
		FinancesPanel.GetComponent<CanvasGroup> ().blocksRaycasts = false;
		ArchivePanel.GetComponent<Canvas> ().enabled = true;
		ArchivePanel.GetComponent<CanvasGroup> ().blocksRaycasts = true;
		ObjectivesPanel.GetComponent<Canvas> ().enabled = false;
		ObjectivesPanel.GetComponent<CanvasGroup> ().blocksRaycasts = false;

	}

	public void SetPanelFinance()
	{
		PanelFastTravel.GetComponent<Canvas> ().enabled = false;
		PanelFastTravel.GetComponent<CanvasGroup> ().blocksRaycasts = false;
		FinancesPanel.GetComponent<Canvas> ().enabled = true;
		FinancesPanel.GetComponent<CanvasGroup> ().blocksRaycasts = true;
		ArchivePanel.GetComponent<Canvas> ().enabled = false;
		ArchivePanel.GetComponent<CanvasGroup> ().blocksRaycasts = false;
		ObjectivesPanel.GetComponent<Canvas> ().enabled = false;
		ObjectivesPanel.GetComponent<CanvasGroup> ().blocksRaycasts = false;
	}





}
