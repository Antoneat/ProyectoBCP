using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HungerController : MonoBehaviour
{
    public float hunger;
    public FoodCounter foodCounter;
    void Start()
    {
        foodCounter = GameObject.Find("FoodManager").GetComponent<FoodCounter>();
        hunger = 0;
    }

    // Update is called once per frame
    void Update()
    {
        hunger += Time.deltaTime;
        {
            if (hunger >= 15)
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
                hunger -= 12.5f;
                Destroy(collision.gameObject);
                foodCounter.foodValue -= 1;
            }
                   
        }
    }
}
