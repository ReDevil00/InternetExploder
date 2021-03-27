using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpawnBug : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private float InstantiationTimer = 3f;
    private double random;
    private System.Random rand = new System.Random();

    public GameObject bug;

    // Update is called once per frame
    void Update()
    {
        CreateBug();
    }

    void CreateBug()
    {
        InstantiationTimer -= Time.deltaTime;
        if (InstantiationTimer <= 0)
        {
            random = (rand.NextDouble() * 18) - 9;
            Instantiate(bug, new Vector3((float)random, 6, 0), Quaternion.identity);
            InstantiationTimer = 1.2f;
        }
    }
}
