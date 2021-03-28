using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class introExp : MonoBehaviour
{
    Vector3[] waypoints;
    int current = 0;
    float speed = 1;
    float WPradius = 0.01f;

    void Start()
    {
        waypoints = new Vector3[3];
        waypoints[0] = new Vector3(-7, 1);
        waypoints[1] = new Vector3(-3, -1);
        waypoints[2] = new Vector3(0, 3);
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(waypoints[current], transform.position) < WPradius)
        {
            if(current < waypoints.Length-1)
            {
                current++;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[current], Time.deltaTime * speed);
    }
}
