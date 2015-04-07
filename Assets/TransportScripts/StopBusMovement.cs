using UnityEngine;
using System.Collections;

public class StopBusMovement : MonoBehaviour
{
    public BoardBus BBStop;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Transport")
        {
            BBStop.CountAI = 0;

        }
    }
}
