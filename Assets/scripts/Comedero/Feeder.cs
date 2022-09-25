using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feeder : MonoBehaviour
{

    private float spawnFood;
    public GameObject food;
    public GameObject food1;
    public GameObject food2;
    public GameObject food3;
    public GameObject feederPos;

    public FoodCounter foodCounter;

    public bool normal;
    public bool mejora1;
    public bool mejora2;
    public bool mejora3;

    // Start is called before the first frame update
    void Start()
    {
        normal = true;
        mejora1 = false;
        mejora2 = false;
        mejora3 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(normal==true)
        {
            SpawnAlfalfa();
        }
        else if(mejora1==true)
        {
            SpawnAlfalfaMejora1();
        }
        else if (mejora2 == true)
        {
            SpawnAlfalfaMejora2();
        }
        else if (mejora3 == true)
        {
            SpawnAlfalfaMejora3();
        }
    }

    void SpawnAlfalfa()
    {
        spawnFood += Time.deltaTime;
        if (spawnFood >= 10f)
        {
            Vector2 randomFeederPos =new Vector2 (feederPos.transform.position.x + Random.Range(-0.4f, 0.4f), feederPos.transform.position.y);
            Instantiate(food, randomFeederPos, feederPos.transform.rotation);
           
            spawnFood = 0;
            foodCounter.foodValue += 1;
        }
    }

    void SpawnAlfalfaMejora1()
    {
        spawnFood += Time.deltaTime;
        if (spawnFood >= 20f)
        {
            Vector2 randomFeederPos = new Vector2(feederPos.transform.position.x + Random.Range(-0.4f, 0.4f), feederPos.transform.position.y);
            Instantiate(food1, randomFeederPos, feederPos.transform.rotation);

            spawnFood = 0;
            foodCounter.foodValue += 3;
        }
    }

    void SpawnAlfalfaMejora2()
    {
        spawnFood += Time.deltaTime;
        if (spawnFood >= 20f)
        {
            Vector2 randomFeederPos = new Vector2(feederPos.transform.position.x + Random.Range(-0.4f, 0.4f), feederPos.transform.position.y);
            Instantiate(food2, randomFeederPos, feederPos.transform.rotation);

            spawnFood = 0;
            foodCounter.foodValue += 6;
        }
    }

    void SpawnAlfalfaMejora3()
    {
        spawnFood += Time.deltaTime;
        if (spawnFood >= 20f)
        {
            Vector2 randomFeederPos = new Vector2(feederPos.transform.position.x + Random.Range(-0.4f, 0.4f), feederPos.transform.position.y);
            Instantiate(food3, randomFeederPos, feederPos.transform.rotation);

            spawnFood = 0;
            foodCounter.foodValue += 10;
        }
    }
}
