using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed = 2;

    [SerializeField]
    public bool fight = false;

    // Update is called once per frame
    private void Update()
    {
        float rawHorizontalAxis = Input.GetAxisRaw("Horizontal");
        float rawVerticalAxis = Input.GetAxisRaw("Vertical");

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
    }
}
