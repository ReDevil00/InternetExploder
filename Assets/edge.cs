using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class edge : MonoBehaviour
{
    Vector3 originalPosition;
    int count;
    public GameObject exploder;

    void Start()
    {
        count = 0;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        originalPosition = transform.position;
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if(col.gameObject.name == "cursor")
        {
            float x = Random.Range(-0.1f, 0.1f);
            float y = Random.Range(-0.1f, 0.1f);

            transform.position = originalPosition + new Vector3(x, y);
            count = count + 1;
            if(count == 100)
            {
                Instantiate(exploder, new Vector3(-7, 3), Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        transform.position = originalPosition;
    }
}
