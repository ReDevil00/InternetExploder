using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class edge : MonoBehaviour
{
    Vector3 originalPosition;
    int count;
    public GameObject exploder;
    public GameObject cursor;
    public GameObject waypoints;

    void Start()
    {
        count = 0;
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
                Instantiate(exploder, new Vector3(-7.75f, 3.75f), Quaternion.identity);
                cursor.GetComponent<Rigidbody2D>().gravityScale = 3.0f;
                Destroy(gameObject);
            }
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        transform.position = originalPosition;
    }
}
