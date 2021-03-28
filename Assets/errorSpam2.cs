using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class errorSpam2 : MonoBehaviour
{
    public GameObject err1;
    public GameObject err2;

    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count++;
        if(count == 50)
        {
            Instantiate(err1, new Vector3(-7,-2), Quaternion.identity);
        }
        if(count == 120)
        {
            Instantiate(err2, new Vector3(5,2), Quaternion.identity);
        }
    }
}
