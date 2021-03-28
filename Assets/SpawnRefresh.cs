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
            random = (rand.NextDouble() * 18) - 9;
            Instantiate(refresh, new Vector3((float)random, 6, 0), Quaternion.identity);
            InstantiationTimer = 15f;
        }
    }
}
