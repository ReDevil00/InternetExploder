using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightWall : MonoBehaviour
{
    private Rigidbody2D rb2D;

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }
}
