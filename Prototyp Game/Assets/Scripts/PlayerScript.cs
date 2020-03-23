using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    private Vector2 startTouchPosition, endTouchPosition;

    void Update()
    {
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            startTouchPosition = Input.GetTouch(0).position;

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endTouchPosition = Input.GetTouch(0).position;

            if((endTouchPosition.x < startTouchPosition.x) && transform.position.x > -3.5f)
                transform.position = new Vector2(transform.position.x - 3.5f, transform.position.y);

            if ((endTouchPosition.x > startTouchPosition.x) && transform.position.x < 3.5f)
                transform.position = new Vector2(transform.position.x + 3.5f, transform.position.y);
        }
    }
}
