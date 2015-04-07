using UnityEngine;
using System.Collections;

public class BoardBus : MonoBehaviour
{
    public BusStopTrigger BSTBB;

    public int CountAI = 0;
    public bool BusAtStop = false;
    public bool busFull;
    public bool digitInside = false;

    public Transform OnBusTransform;


    //private int currentPoint;

    //public Transform BusStop;

    // Use this for initialization
    void Start()
    {
        //currentPoint = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (busFull == true)
        {
            Debug.Log("Bus Full");
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        //		if (other.gameObject.tag == "Digit") 
        //		{
        //			Debug.Log("digit inside");
        //			digitInside = true;
        //		}

        if (other.gameObject.tag == "Transport")
        {
            BusAtStop = true;
            Debug.Log("TransportBoarding");
        }

        if (other.gameObject.tag == "Digit" && BusAtStop == true)
        {
            CountAI++;
            //currentPoint++;

            Debug.Log("Digit Hit");

            if (CountAI <= 6)
            {

                other.gameObject.transform.position = OnBusTransform.position;
                other.gameObject.renderer.enabled = (false);

            }


        }


    }



}



