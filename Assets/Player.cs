using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    [SerializeField]
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> c86de2fe0a2cb1c7718631d3ce7e0d64578355ee
    public GameObject floor;

    private Rigidbody2D rb2d;

<<<<<<< HEAD
    private Vector3 move = Vector3.zero;

    [SerializeField]
=======
    [SerializeField]
=======
>>>>>>> 55f1b81f88a9f434d311955e4a0965104f15ff70
>>>>>>> c86de2fe0a2cb1c7718631d3ce7e0d64578355ee
    private float speed = 2;

    [SerializeField]
    public bool fight = false;

<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> c86de2fe0a2cb1c7718631d3ce7e0d64578355ee
    [SerializeField]
    private float fallSpeed = 3.0f;

    [SerializeField]
    private float spinSpeed = 500.0f;

<<<<<<< HEAD
    [SerializeField]
    private bool onGround = false;
=======
    bool shouldMove = true;
>>>>>>> c86de2fe0a2cb1c7718631d3ce7e0d64578355ee

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

<<<<<<< HEAD
=======
=======
>>>>>>> 55f1b81f88a9f434d311955e4a0965104f15ff70
>>>>>>> c86de2fe0a2cb1c7718631d3ce7e0d64578355ee
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && shouldMove)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }

<<<<<<< HEAD
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

<<<<<<< HEAD
       /*
        else if (onGround == false)
            {
                transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
                transform.Rotate(Vector3.forward, spinSpeed * Time.deltaTime);
            }
        */
=======
        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.name == "floor")
            {
                shouldMove = false;
            }
        }
=======
        Vector3 direction = Vector3.zero;
        direction.x = rawHorizontalAxis;
>>>>>>> c86de2fe0a2cb1c7718631d3ce7e0d64578355ee

        move.x = rawHorizontalAxis;
        if(fight == false)
        {
            move.y = rawVerticalAxis;
        }
         
    }
    
    private void FixedUpdate()
    {
        if(move != Vector3.zero)
        {
            Vector3 translation = move * speed * Time.fixedDeltaTime;
            Vector3 newPosition = transform.position + translation;

<<<<<<< HEAD
            rb2d.MovePosition(newPosition);
        }
=======
        float timeSinceLastFrame = Time.deltaTime;

        Vector3 translation = direction * speed * timeSinceLastFrame;

        transform.Translate(
            translation
        );
>>>>>>> 55f1b81f88a9f434d311955e4a0965104f15ff70
>>>>>>> c86de2fe0a2cb1c7718631d3ce7e0d64578355ee
    }
}
