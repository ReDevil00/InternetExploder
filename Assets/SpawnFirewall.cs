using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpawnFirewall : MonoBehaviour
{

    public AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
	sound = GetComponent<AudioSource>();
    }

    private float InstantiationTimer = 7.5f;
    private double random;
    private System.Random rand = new System.Random();

    public GameObject firewall;

    // Update is called once per frame
    void Update()
    {
        CreateFirewall();
    }

    void CreateFirewall()
    {
        InstantiationTimer -= Time.deltaTime;
        if (InstantiationTimer <= 0)
        {
            random = (rand.NextDouble() * 18) - 9;
            Instantiate(firewall, new Vector3((float)random, 6, 0), Quaternion.identity);
            InstantiationTimer = 15f;
        }
    }
}
