using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exploder : MonoBehaviour
{
    public AudioClip click;
    public GameObject cursor;
    public GameObject recycle;
    public GameObject greyExploder;

    // Start is called before the first frame update
    void Start()
    {
        greyExploder = GetComponent<GameObject>();
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = click;
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.name == "cursor")
        {
            GetComponent<AudioSource>().Play();
            //GameObject.Find("cursor").GetComponent<InputScreenPlayer>().hasExploder = true;
            Instantiate(recycle, new Vector3(7.75f, 3.0f), Quaternion.identity);
            GameObject.Find("exploderGray").transform.parent = cursor.transform;
            

        }
        if(collision.gameObject.name == "recycle")
        {
            Destroy(greyExploder);
        }
    }
}
