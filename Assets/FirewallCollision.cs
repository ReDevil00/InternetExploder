using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class FirewallCollision : MonoBehaviour
{
    private Rigidbody2D rb2D;
    public GameObject firewall;

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
        if (col.gameObject.name == "cursor")
        {
            //Handle Firewall
            
            GameObject.Find("firewall").GetComponent<AudioSource>().Play();

	    if(!GameObject.Find("cursor").GetComponent<Player>().hasShield)
            {
                var newFirewall = Instantiate(firewall, new Vector3(col.gameObject.transform.position.x,
                    col.gameObject.transform.position.y, 0), Quaternion.identity);
                newFirewall.transform.parent = col.transform;
            }
	    GameObject.Find("cursor").GetComponent<Player>().hasShield = true;

            Destroy(gameObject); //Destroy the firewall powerup object
        }
    }
}
