using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodController : MonoBehaviour
{
    private float hunger;
    void Start()
    {
        hunger = 0;
    }

    // Update is called once per frame
    void Update()
    {
        hunger += Time.deltaTime;
        {
            if (hunger >= 10)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("food"))
        {

          if (hunger >= 1)
            {
                hunger -= 1;
                Destroy(collision.gameObject);
            }
                   
        }
    }
}
