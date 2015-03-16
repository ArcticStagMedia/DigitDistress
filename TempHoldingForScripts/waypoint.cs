using UnityEngine;
using System.Collections;

public class waypoint : MonoBehaviour {

    public float radius;

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;        
        Gizmos.DrawWireSphere(transform.position, radius);
    }

}
