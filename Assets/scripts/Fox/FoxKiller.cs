using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxKiller : MonoBehaviour
{
    TouchPhase touchPhase = TouchPhase.Ended;
    Vector3 touchPosWorld;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        KillFox();
    }

    void KillFox()
    {

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == touchPhase)
        {
            //We transform the touch position into word space from screen space and store it.
            touchPosWorld = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);

            Vector2 touchPosWorld2D = new Vector2(touchPosWorld.x, touchPosWorld.y);

            //We now raycast with this information. If we have hit something we can process it.
            RaycastHit2D hitInformation = Physics2D.Raycast(touchPosWorld2D, Camera.main.transform.forward);

            if (hitInformation.collider != null)
            {
                //We should have hit something with a 2D Physics collider!
                GameObject touchedObject = hitInformation.transform.gameObject;
                //touchedObject should be the object someone touched.
                Debug.Log("Touched " + touchedObject.transform.name);

                if (Input.touchCount >= 5)
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}
