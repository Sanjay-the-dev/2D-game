using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{

    [SerializeField] private GameObject[] waypoints;
    [SerializeField] private float speed = 2f;
    private int currentwaypointindex;
    void Update()
    {
        if (Vector2.Distance(waypoints[currentwaypointindex].transform.position, transform.position) < 0.00001f)
        {
            currentwaypointindex++;
            if (currentwaypointindex >= waypoints.Length)
            {
                currentwaypointindex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentwaypointindex].
            transform.position, speed * Time.deltaTime);

    }
}
