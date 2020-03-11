using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackgroundScript : MonoBehaviour
{
    float curx;
    
    // Start is called before the first frame update
    void Start()
    {
        curx = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -1f)
        {
            transform.position = new Vector3(transform.position.x, 19, transform.position.z);
        }
        else
        {
            curx = transform.position.y - 0.05f;
            transform.position = new Vector3(transform.position.x, curx, transform.position.z);
        }
    }
}
