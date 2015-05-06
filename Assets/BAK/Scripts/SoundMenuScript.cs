using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SoundMenuScript : MonoBehaviour 
{

	public Slider SoundLevel;
	public AudioSource Music;
	public Toggle VolumeMuted;


	// Use this for initialization
	void Start () 
	{

	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (VolumeMuted.isOn) 
		{
			AudioListener.volume = SoundLevel.value;
		} else 
		{
			AudioListener.volume = 0;
		}
	}
}
