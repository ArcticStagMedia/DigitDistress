using UnityEngine;
using System.Collections;

public class SpawnDigit : MonoBehaviour
{
    public GameObject digit;
    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            GameObject digitClone;
            digitClone = Instantiate(digit) as GameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
