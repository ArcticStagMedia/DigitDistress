using UnityEngine;
using System.Collections;

public class LoseWinScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Play()
    {
        ///print("Play");
        ///

        Application.LoadLevel("Floor1");
    }

    public void Quiit()
    {
       // print("Quit");

        Application.Quit();
    }
}
