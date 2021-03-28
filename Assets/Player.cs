using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    [SerializeField]
    public GameObject floor;

    [SerializeField]
    public GameObject leftWall;

    [SerializeField]
    public GameObject rightWall;

    [SerializeField]
    public GameObject ceiling;

    private Rigidbody2D rb2d;

    [SerializeField]
    private float speed = 3;

    bool shouldMoveLeft = true;
    bool shouldMoveRight = true;
    bool shouldMoveUp = true;
    bool shouldMoveDown = true;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.gravityScale = 0.0f;
        rb2d.velocity = Vector2.zero;
    }

    // Update is called once per frame
    private void Update()
    {
        if ((Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) && shouldMoveUp)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }

        if ((Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) && shouldMoveDown)
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }

        if ((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) && shouldMoveLeft)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

        if ((Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) && shouldMoveRight)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }
        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.name == "floor")
            {
                shouldMoveDown = false;
            }

            if(collision.gameObject.name == "leftWall")
            {
                shouldMoveLeft = false;
            }
            
            if(collision.gameObject.name == "rightWall")
            {
                shouldMoveRight = false;
            }

            if(collision.gameObject.name == "ceiling")
            {
                shouldMoveUp = false;
            }
        }
}

      
