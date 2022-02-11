using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    Vector3 firstTouchPosition;
    Vector3 lastTouchPosition;
    float dragDistance;

    void Start()
    {
        dragDistance = Screen.height * 15 / 100;

    }


    void Update()
    {
        if (Input.touchCount == 1) // user is touching the screen with a single touch
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                firstTouchPosition = touch.position;
                lastTouchPosition = touch.position;
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                lastTouchPosition = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                lastTouchPosition = touch.position;

                if (Mathf.Abs(lastTouchPosition.x - firstTouchPosition.x) > dragDistance || Mathf.Abs(lastTouchPosition.y - firstTouchPosition.y) > dragDistance)
                {
                    if (Mathf.Abs(lastTouchPosition.x - firstTouchPosition.x) > Mathf.Abs(lastTouchPosition.y - firstTouchPosition.y))
                    {
                        if ((lastTouchPosition.x > firstTouchPosition.x))
                        {   //Right swipe
                            //Vector3.Lerp(transform.localPosition, transform.localPosition += Vector3.right * 2, 0.05f);
                            transform.localPosition += Vector3.right * 2;
                        }
                        else
                        {   //Left swipe
                            //Vector3.Lerp(transform.localPosition, transform.localPosition += Vector3.left * 2, 0.5f);
                            transform.localPosition += Vector3.left * 2;
                        }
                    }
                    else
                    {
                        if (lastTouchPosition.y > firstTouchPosition.y)
                        {   //Up swipe
                            transform.Translate(0, 4f, 0);

                        }
                    }
                }
                else
                {
                    Debug.Log("Tap");
                }
            }
        }
    }
}