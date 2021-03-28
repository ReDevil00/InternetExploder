using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exploder : MonoBehaviour
{
    public GameObject cursor;
    public GameObject recycle;
    public GameObject greyExploder;

    // Start is called before the first frame update
    void Start()
    {
        greyExploder = GetComponent<GameObject>();
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        if(collider.gameObject.name == "cursor")
        {
            GameObject.Find("cursor").GetComponent<InputScreenPlayer>().hasExploder = true;
            Instantiate(recycle, new Vector3(7.75f, 3.0f), Quaternion.identity);
            GameObject.Find("exploderGray").transform.parent = cursor.transform;

            //make click sound
        }
    }
}
