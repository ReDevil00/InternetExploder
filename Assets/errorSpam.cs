using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class errorSpam : MonoBehaviour
{
    public GameObject err;

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
            Instantiate(err, new Vector3(6,-2), Quaternion.identity);
        }
    }
}
