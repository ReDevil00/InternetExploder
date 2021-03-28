using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    [SerializeField]
    public GameObject floor;

    private Rigidbody2D rb2d;

    private Vector3 move = Vector3.zero;

    [SerializeField]
    private float speed = 2;

    [SerializeField]
    public bool fight = false;

    [SerializeField]
    private float fallSpeed = 3.0f;

    [SerializeField]
    private float spinSpeed = 500.0f;

    bool shouldMove = true;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
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
        /*
         else if (onGround == false)
             {
                 transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
                 transform.Rotate(Vector3.forward, spinSpeed * Time.deltaTime);
             }
         */
    }
        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.name == "floor")
            {
                shouldMove = false;
            }
        }
}

      
