using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class introExp : MonoBehaviour
{
    public GameObject dia1;
    GameObject temp1;
    public GameObject dia2;
    GameObject temp2;
    public GameObject dia3;
    Vector3[] waypoints;
    int current = 0;
    float speed = 1;
    float WPradius = 0.01f;
    bool bSingle = false;
    int count = 0;

    void Start()
    {
        waypoints = new Vector3[3];
        waypoints[0] = new Vector3(-7, -1);
        waypoints[1] = new Vector3(-2, 0);
        waypoints[2] = new Vector3(0, 3);
        temp1 = Instantiate(dia1, new Vector3(-1.5f, 3), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(waypoints[current], transform.position) < WPradius)
        {
            if(current < waypoints.Length-1)
            {
                current++;
                if(current == 1)
                {
                    Destroy(temp1);
                    temp2 = Instantiate(dia2, new Vector3(-5, 2), Quaternion.identity);
                }
            }
            if(current == 2 && !bSingle)
            {
                Destroy(temp2);
                Instantiate(dia3, new Vector3(5, 2), Quaternion.identity);
		bSingle = true;
            }
            if(current == 2)
            {
                count++;
                if(count > 50)
                {
                    SceneManager.LoadScene("Boss Battle");
                }
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[current], Time.deltaTime * speed);
    }
}
