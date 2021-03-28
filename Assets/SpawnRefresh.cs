using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpawnRefresh : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    private float InstantiationTimer = 15f;
    private double random;
    private System.Random rand = new System.Random();
    public GameObject exploder;
    public GameObject exploderGray;

    public GameObject dia4;
    public GameObject dia5;
    public GameObject dia6;
    public GameObject dia7;
    int count = 0;
    public GameObject err1;
    public GameObject err2;
    public GameObject err3;

    public GameObject refresh;

    // Update is called once per frame
    void Update()
    {
        CreateRefresh();
    }

    void CreateRefresh()
    {
        InstantiationTimer -= Time.deltaTime;
        if (InstantiationTimer <= 0)
        {
            random = (rand.NextDouble() * 17) - 8.5;
            Instantiate(refresh, new Vector3((float)random, 6, 0), Quaternion.identity);
            InstantiationTimer = 15f;
        } else if (InstantiationTimer <= 5f && GameObject.Find("cursor").GetComponent<Player>().bReset == false)
        {
            Instantiate(exploder, new Vector3(GameObject.Find("exploderGray(Clone)").transform.position.x,
                        GameObject.Find("exploderGray(Clone)").transform.position.y, 0), Quaternion.identity);
            Destroy(GameObject.Find("exploderGray(Clone)"));
            count++;
            if(count == 1)
            {
		Instantiate(dia4, new Vector3(3,3), Quaternion.identity);
            }
	    if(count == 2)
            {
		Instantiate(dia5, new Vector3(4,3), Quaternion.identity);
		Instantiate(err1, new Vector3(-6,2), Quaternion.identity);
            }
	    if(count == 3)
            {
		Instantiate(dia6, new Vector3(5,3), Quaternion.identity);
		Instantiate(err2, new Vector3(1,0), Quaternion.identity);
            }
	    if(count == 4)
            {
		Instantiate(dia7, new Vector3(3,3), Quaternion.identity);
		Instantiate(err3, new Vector3(-1,-2), Quaternion.identity);
            }
            GameObject.Find("cursor").GetComponent<Player>().bReset = true;
        }
    }
}
