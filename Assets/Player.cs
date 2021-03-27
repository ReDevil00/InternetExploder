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

    [SerializeField]
    private bool onGround = false;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        float rawHorizontalAxis = Input.GetAxisRaw("Horizontal");
        float rawVerticalAxis = Input.GetAxisRaw("Vertical");

       /*
        else if (onGround == false)
            {
                transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
                transform.Rotate(Vector3.forward, spinSpeed * Time.deltaTime);
            }
        */

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

            rb2d.MovePosition(newPosition);
        }
    }
}
