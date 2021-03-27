using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed = 2;

    // Update is called once per frame
    private void Update()
    {
        float rawHorizontalAxis = Input.GetAxisRaw("Horizontal");

        Vector3 direction = Vector3.zero;
        direction.x = rawHorizontalAxis;

        float timeSinceLastFrame = Time.deltaTime;

        Vector3 translation = direction * speed * timeSinceLastFrame;

        transform.Translate(
            translation
        );
    }
}
