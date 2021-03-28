using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    [SerializeField]
    public GameObject floor;

    private Rigidbody2D rb2d;

    [SerializeField]
    private float speed = 2;

    bool shouldMove = true;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.gravityScale = 0.0f;
        rb2d.velocity = Vector2.zero;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && shouldMove)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow) && shouldMove)
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }
        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.name == "floor")
            {
                shouldMove = false;
            }
        }
}

      
