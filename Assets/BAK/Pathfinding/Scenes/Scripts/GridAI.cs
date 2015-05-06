using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GridAI : Pathfinding
{

    public Vector3 waypoint;
    public GameObject waypointGameobject;
    private bool recivedNewObjective = false;

    void Update()
    {
        if (Random.seed == 0)
        {
            Random.seed = System.DateTime.Now.Millisecond;
        }
        if (transform.position.y != 1)
        {
            transform.position.Set(transform.position.x, 2, transform.position.z);
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
        if (waypointGameobject != null)
        {
            waypoint = waypointGameobject.transform.position;
        }
        if (waypoint == Vector3.zero)
        {
            waypoint = new Vector3(Random.Range(-120, 120), 1, Random.Range(-120, 120));
        }
        if (Path.Count == 0 && waypointGameobject != null)
        {
            waypointGameobject = null;
        }
        FindPath(transform.position, waypoint);
    }

    private void MoveMethod()
    {
        if (Path.Count > 0)
        {
            if (transform.position.y != 1)
            {
                transform.position.Set(transform.position.x, 2, transform.position.z);
            }
           

            Vector3 direction = (Path[0] - transform.position).normalized;
            Vector3 lookDirection = Path[0];
            lookDirection.y = 1.0f;

            transform.LookAt(lookDirection);
            transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, Time.deltaTime * 14F);

            if (collider.bounds.Contains(Path[0]))
            {
                Path.RemoveAt(0);
            }

            RaycastHit[] hit = Physics.RaycastAll(transform.position + (Vector3.up * 20F), Vector3.down, 100);
            float maxY = -Mathf.Infinity;
            foreach (RaycastHit h in hit)
            {
                if (h.transform.tag == "Grass" || h.transform.tag == "Path")
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

