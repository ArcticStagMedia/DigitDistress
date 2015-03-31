using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GridAI : Pathfinding {

    public Vector3 waypoint;

	void Update () 
    {
        if(transform.position.z > 1)
        {
            transform.position.Set(transform.position.x,1,transform.position.z);
        }
        FindPath();
        if (Path.Count > 0)
        {
            MoveMethod();
        }
	}

    private void FindPath()
    {
        if(waypoint == null)
        {
            waypoint = new Vector3(Random.Range(1, 120), 1, Random.Range(1, 120));
            FindPath(transform.position, waypoint);
        }
        else{
        FindPath(transform.position, waypoint);
        }
    }

    private void MoveMethod()
    {
        if (Path.Count > 0)
        {
            Vector3 direction = (Path[0] - transform.position).normalized;

            transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, Time.deltaTime * 14F);
            if (transform.position.x < Path[0].x + 0.4F && transform.position.x > Path[0].x - 0.4F && transform.position.z > Path[0].z - 0.4F && transform.position.z < Path[0].z + 0.4F)
            {
                Path.RemoveAt(0);
            }

            RaycastHit[] hit = Physics.RaycastAll(transform.position + (Vector3.up * 20F), Vector3.down, 100);
            float maxY = -Mathf.Infinity;
            foreach (RaycastHit h in hit)
            {
                if (h.transform.tag == "Untagged")
                {
                    if (maxY < h.point.y)
                    {
                        maxY = h.point.y;
                    }
                }
            }
            transform.position = new Vector3(transform.position.x, maxY + 1F, transform.position.z);
        }
    }

}

