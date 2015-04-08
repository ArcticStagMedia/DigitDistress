using UnityEngine;
using System.Collections;

public class DynamicUpdater : MonoBehaviour {
    Pathfinder path;
	// Use this for initialization
	void Start () {
        path = GetComponent<Pathfinder>();
	}
	
	// Update is called once per frame
	void Update () {
        path.Start();
	}
}
