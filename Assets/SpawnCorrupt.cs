using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpawnCorrupt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    private float InstantiationTimer = 7f;
    private double random;
    private System.Random rand = new System.Random();

    public GameObject corrupt;

    // Update is called once per frame
    void Update()
    {
        CreateCorrupt();
    }

    void CreateCorrupt()
    {
        InstantiationTimer -= Time.deltaTime;
        if (InstantiationTimer <= 0)
        {
            random = (rand.NextDouble() * 18) - 9;
            Instantiate(corrupt, new Vector3((float)random, 6, 0), Quaternion.identity);
            InstantiationTimer = 2.5f;
        }
    }
}
