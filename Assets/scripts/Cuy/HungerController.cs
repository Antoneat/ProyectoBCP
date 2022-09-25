using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HungerController : MonoBehaviour
{
    public float hunger;
    public FoodCounter foodCounter;
    void Start()
    {
        hunger = 0;
    }

    // Update is called once per frame
    void Update()
    {
        hunger += Time.deltaTime;
        {
            if (hunger >= 25)
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
                hunger -= 5;
                Destroy(collision.gameObject);
                foodCounter.foodValue -= 1;
            }
                   
        }
    }
}
