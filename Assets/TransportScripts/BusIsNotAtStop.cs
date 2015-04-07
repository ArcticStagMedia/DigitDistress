using UnityEngine;
using System.Collections;

public class BusIsNotAtStop : MonoBehaviour
{
    public BoardBus NoBoard;
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
            NoBoard.BusAtStop = false;
        }
    }
}
