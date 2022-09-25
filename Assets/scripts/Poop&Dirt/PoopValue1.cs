using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoopValue1 : MonoBehaviour
{
    private MoneyController mc;
    [SerializeField] private float value;
    TouchPhase touchPhase = TouchPhase.Ended;
    Vector3 touchPosWorld;
    void Start()
    {
        mc = GameObject.Find("MoneyManager").GetComponent<MoneyController>();
    }

    // Update is called once per frame
    void Update()
    {
        RandomPoopValue();
    }

    void RandomPoopValue()
    {
        int i = Random.Range(1, 6);

        if (i <= 2)
        {
            value = 2;
        }
        else if (i == 3 || i == 4)
        {
            value = 1;
        }
        else if (i == 5)
        {
            value =3;
        }

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
                if (gameObject.CompareTag("poop"))
                {
                    mc.Money += value;
                    Destroy(gameObject);
                }
            }
        }
    }
}

