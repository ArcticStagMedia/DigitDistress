using UnityEngine;
using System.Collections;

public class PlacementOrb : MonoBehaviour {

    public GameObject BuilderObject;

    
	// Use this for initialization
	void Start () 
    {
        BuilderObject.SetActive(false);
	}
	
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            BuilderObject.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
            BuilderObject.SetActive(false);
    }
}
