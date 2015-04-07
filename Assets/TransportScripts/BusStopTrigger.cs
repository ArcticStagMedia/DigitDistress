using UnityEngine;
using System.Collections;

public class BusStopTrigger : MonoBehaviour
{
    public BoardBus BB;
    public bool BusIsAtStop = false;
    public Transform BusStop;
    //GameObject Digits;
    // Use this for initialization
    void Start()
    {
        //Digits = GameObject.Find("Digits");
    }

    // Update is called once per frame
    void Update()
    {


    }
    public void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "Transport")
        {
            BusIsAtStop = true;
            Debug.Log("Bus Stopped");
            //BB.CountAI = 0;
        }

        if (other.gameObject.tag == "AI" && BusIsAtStop == true)
        {
            //BB.CountAI++;

            Debug.Log("Leaving Stop");
            other.gameObject.transform.position = BusStop.position;
            other.gameObject.renderer.enabled = (true);

            //if (BB.CountAI <= 6) {	


            //} 

        }
        if (other.gameObject.tag == "AI")
        {
            Debug.Log("There in trigger");
        }


    }
    //	public void OnTriggerStay(Collider other)
    //	{		if (other.gameObject.tag == "Bus") {
    //			BusIsAtStop = true;
    //			BB.CountAI = 0;
    //
    //		} 
    //
    //
    //	}

}