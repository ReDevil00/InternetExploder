using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]
public class HandleCollisions : MonoBehaviour
{
    private Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //THIS WORKS :D
        if(col.gameObject.name == "cursor")
        {
            SceneManager.LoadScene("Intro");
        }   
    }
}
