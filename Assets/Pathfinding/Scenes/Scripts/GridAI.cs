using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GridAI : Pathfinding
{

    public Vector3 waypoint;
    public GameObject waypointGameobject;

    void Update()
    {
        if (Random.seed == 0)
        {
            Random.seed = System.DateTime.Now.Millisecond;
        }
        if (transform.position.z > 1)
        {
            transform.position.Set(transform.position.x, 1, transform.position.z);
        }
        FindPath();
        if (Path.Count > 0)
        {
            MoveMethod();
        }
        else
        {
            waypoint = Vector3.zero;
        }
    }

    private void FindPath()
    {
        waypoint = waypointGameobject.transform.position;
        //if (waypoint == Vector3.zero)
        //{
        //    waypoint = new Vector3(Random.Range(1, 120), 1, Random.Range(1, 120));
        //}
        FindPath(transform.position, waypoint);
    }

    private void MoveMethod()
    {
        if (Path.Count > 0)
        {
            Vector3 direction = (Path[0] - transform.position).normalized;

            transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, Time.deltaTime * 14F);

            //transform.LookAt(Path[0]);
            //transform.Translate(transform.forward * Time.fixedDeltaTime * 14f);

            if (transform.position.x < Path[0].x + 0.4F && transform.position.x > Path[0].x - 0.4F && transform.position.z > Path[0].z - 0.4F && transform.position.z < Path[0].z + 0.4F)
            {
                Path.RemoveAt(0);
            }

            //if (collider.bounds.Contains(Path[0]))
            //{
            //    Path.RemoveAt(0);
            //}

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

