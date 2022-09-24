using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feeder : MonoBehaviour
{

    private float spawnFood;
    public GameObject food;
    public GameObject feederPos;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        SpawnAlfalfa();
    }

    void SpawnAlfalfa()
    {
        spawnFood += Time.deltaTime;
        if (spawnFood >= 20f)
        {
            Instantiate(food, feederPos.transform.position, feederPos.transform.rotation);
            spawnFood = 0;
        }
    }

}
