using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]
public class RefreshCollision : MonoBehaviour
{
    private Rigidbody2D rb2D;

    [SerializeField]
    private SpriteRenderer full;

    [SerializeField]
    private SpriteRenderer eighty;

    [SerializeField]
    private SpriteRenderer sixty;

    [SerializeField]
    private SpriteRenderer forty;

    [SerializeField]
    private SpriteRenderer twenty;

    [SerializeField]
    private SpriteRenderer empty;

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

        full.sortingOrder = 10;
        eighty.sortingOrder = 9;
        sixty.sortingOrder = 8;
        forty.sortingOrder = 7;
        twenty.sortingOrder = 6;
        empty.sortingOrder = 5;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //THIS WORKS :D
        if (col.gameObject.name == "cursor")
        {
            Destroy(gameObject);
            
            if(eighty.sortingOrder != 10)
            {
                eighty.sortingOrder += 1;
                sixty.sortingOrder += 1;
                forty.sortingOrder += 1;
                twenty.sortingOrder += 1;
                empty.sortingOrder += 1;
            }
            else if(sixty.sortingOrder != 10)
            {
                sixty.sortingOrder += 1;
                forty.sortingOrder += 1;
                twenty.sortingOrder += 1;
                empty.sortingOrder += 1;
            }
            else if(forty.sortingOrder != 10)
            {
                forty.sortingOrder += 1;
                twenty.sortingOrder += 1;
                empty.sortingOrder += 1;
              
            }
            else if(twenty.sortingOrder != 10)
            {
                twenty.sortingOrder += 1;
                empty.sortingOrder += 1;
            }
            else if(empty.sortingOrder != 10)
            {
                empty.sortingOrder += 1;
            }
           

        }
    }
}
