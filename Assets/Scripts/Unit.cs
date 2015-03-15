using UnityEngine;
using System.Collections;

public class Unit : MonoBehaviour {

    public Transform[] target;
    public int selectedTarget = 0;
    public float speed = 50;
    Vector3[] path;
    int targetIndex;

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            SelectTarget();
            PathRequestManager.RequestPath(transform.position, target[selectedTarget].position, OnPathFound);
        }
    }

    public void OnPathFound(Vector3[] newPath, bool pathSuccessful)
    {
        if (pathSuccessful)
        {
            path = newPath;
            StopCoroutine("FollowPath");
            StartCoroutine("FollowPath");
        }
    }

    public void SelectTarget()
    {
        Vector3 distance;
        if ( selectedTarget > target.Length)
        {
            selectedTarget = 0;
            distance = target[selectedTarget].position - transform.position;
        }
        else
        {
            distance = target[selectedTarget].position - transform.position;
        }

        if (distance.magnitude < 1 && selectedTarget < target.Length)
        {
            selectedTarget++;
            if (selectedTarget > target.Length)
            {
                selectedTarget = 0;
            }

        }
        else
        {

            return;
        }
    }

    IEnumerator FollowPath()
    {
        Vector3 currentWaypoint = path[0];

        while (true)
        {
            if (transform.position == currentWaypoint)
            {
                targetIndex++;
                if (targetIndex >= path.Length)
                {
                    yield break;
                }
                currentWaypoint = path[targetIndex];
            }

            transform.position = Vector3.MoveTowards(transform.position, currentWaypoint, speed*Time.deltaTime);
            yield return null;
        }
    }

    public void OnDrawGizmos()
    {
        if (path != null)
        {
            for (int i = targetIndex; i<path.Length; i++)
            {
                Gizmos.color = Color.black;
                Gizmos.DrawCube(path[i],Vector3.one);

                if (i== targetIndex)
                {
                    Gizmos.DrawLine(transform.position,path[i]);
                }else{
                    Gizmos.DrawLine(path[i-1],path[i]);
                }
            }
        }
    }
}
