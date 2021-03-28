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

    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;
    public GameObject five;

    public GameObject exploder;
    public GameObject exploderGray;

    public GameObject error1;
    public GameObject error2;
    public GameObject error3;
    public GameObject error4;

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

            int numDamage = GameObject.Find("cursor").GetComponent<Player>().damageTaken;

            switch (numDamage)
            {
                case 0:
                    Instantiate(one, new Vector3(GameObject.Find("healthFull").transform.position.x,
                        GameObject.Find("healthFull").transform.position.y, 0), Quaternion.identity);
                    Destroy(GameObject.Find("healthFull"));
                    GameObject.Find("cursor").GetComponent<Player>().damageTaken++;
                    Instantiate(exploderGray, new Vector3(GameObject.Find("exploder(Clone)").transform.position.x,
                        GameObject.Find("exploder(Clone)").transform.position.y, 0), Quaternion.identity);
                    Destroy(GameObject.Find("exploder(Clone)"));
                    break;
                case 1:
                    Instantiate(two, new Vector3(GameObject.Find("health80(Clone)").transform.position.x,
                        GameObject.Find("health80(Clone)").transform.position.y, 0), Quaternion.identity);
                    Destroy(GameObject.Find("health80(Clone)"));
                    GameObject.Find("cursor").GetComponent<Player>().damageTaken++;
                    Instantiate(exploderGray, new Vector3(GameObject.Find("exploder1(Clone)").transform.position.x,
                        GameObject.Find("exploder1(Clone)").transform.position.y, 0), Quaternion.identity);
                    Destroy(GameObject.Find("exploder1(Clone)"));
                    Instantiate(error1, new Vector3(-6, 2, 0), Quaternion.identity);


                    break;
                case 2:
                    Instantiate(three, new Vector3(GameObject.Find("health60(Clone)").transform.position.x,
                        GameObject.Find("health60(Clone)").transform.position.y, 0), Quaternion.identity);
                    Destroy(GameObject.Find("health60(Clone)"));
                    GameObject.Find("cursor").GetComponent<Player>().damageTaken++;
                    Instantiate(exploderGray, new Vector3(GameObject.Find("exploder(Clone)").transform.position.x,
                        GameObject.Find("exploder(Clone)").transform.position.y, 0), Quaternion.identity);
                    Destroy(GameObject.Find("exploder(Clone)"));
                    break;
                case 3:
                    Instantiate(four, new Vector3(GameObject.Find("health40(Clone)").transform.position.x,
                        GameObject.Find("health40(Clone)").transform.position.y, 0), Quaternion.identity);
                    Destroy(GameObject.Find("health40(Clone)"));
                    GameObject.Find("cursor").GetComponent<Player>().damageTaken++;
                    Instantiate(exploderGray, new Vector3(GameObject.Find("exploder(Clone)").transform.position.x,
                        GameObject.Find("exploder(Clone)").transform.position.y, 0), Quaternion.identity);
                    Destroy(GameObject.Find("exploder(Clone)"));
                    break;
                case 4:
                    Instantiate(five, new Vector3(GameObject.Find("health20(Clone)").transform.position.x,
                        GameObject.Find("health20(Clone)").transform.position.y, 0), Quaternion.identity);
                    Destroy(GameObject.Find("health20(Clone)"));
                    GameObject.Find("cursor").GetComponent<Player>().damageTaken++;
                    Instantiate(exploderGray, new Vector3(GameObject.Find("exploder(Clone)").transform.position.x,
                        GameObject.Find("exploder(Clone)").transform.position.y, 0), Quaternion.identity);
                    Destroy(GameObject.Find("exploder(Clone)"));
                    SceneManager.LoadScene("Outro");
                    break;
            }

            /*if(eighty.sortingOrder != 10)
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
            }*/
           

        }
    }
}
