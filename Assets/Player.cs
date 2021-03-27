using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
<<<<<<< HEAD
    public GameObject floor;

    private Rigidbody2D rb2d;

    [SerializeField]
=======
>>>>>>> 55f1b81f88a9f434d311955e4a0965104f15ff70
    private float speed = 2;

    [SerializeField]
    public bool fight = false;

<<<<<<< HEAD
    [SerializeField]
    private float fallSpeed = 3.0f;

    [SerializeField]
    private float spinSpeed = 500.0f;

    bool shouldMove = true;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

=======
>>>>>>> 55f1b81f88a9f434d311955e4a0965104f15ff70
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

        if (fight == false)
        {
            direction.y = rawVerticalAxis;
        }

        float timeSinceLastFrame = Time.deltaTime;

        Vector3 translation = direction * speed * timeSinceLastFrame;

        transform.Translate(
            translation
        );
>>>>>>> 55f1b81f88a9f434d311955e4a0965104f15ff70
    }
}
