using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragFood : MonoBehaviour
{
    float deltaX, deltaY;
    Rigidbody2D rb;
    bool moveAllowed=false;

    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos= Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);

            switch (touch.phase)
            {
                case TouchPhase.Began:

                    if(GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                    {
                        deltaX = touchPos.x - transform.position.x;
                        deltaY = touchPos.y - transform.position.y;

                        moveAllowed = true;

                        rb.freezeRotation = true;
                        rb.velocity = Vector2.zero;
                        rb.gravityScale = 0;

                    }
                    break;

                case TouchPhase.Moved:

                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos) && moveAllowed)
                    {
                      rb.MovePosition(new Vector2(touchPos.x - deltaX, touchPos.y - deltaY));
                    }
                    break;

                case TouchPhase.Ended:

                    moveAllowed = false;
                    rb.freezeRotation = false;
                    rb.gravityScale = 2;
                    break;
            }

        }
    }
}
