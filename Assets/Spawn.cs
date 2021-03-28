using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Spawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private float InstantiationTimer = 1f;
    private double random;
    private System.Random rand = new System.Random();

    public GameObject Virus;

    // Update is called once per frame
    void Update()
    {
        CreateVirus();
    }

    void CreateVirus()
    {
        InstantiationTimer -= Time.deltaTime;
        if (InstantiationTimer <= 0)
        {
            random = (rand.NextDouble() * 17) - 8.5f;
            Instantiate(Virus, new Vector3((float)random,6,0), Quaternion.identity);
            InstantiationTimer = 1f;
        }
    }
}
