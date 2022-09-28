using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoopController : MonoBehaviour
{
    public GameObject poop;
  
    private float spawnTime;

    //public float spawnDelay;

    public GameObject[] poops;
    public GameObject[] cuyes;
    void Start()
    {
        poops= new GameObject[poops.Length];
        cuyes = new GameObject[6];

       // cuy = GameObject.FindGameObjectWithTag("Cuy");

     // InvokeRepeating("SpawnPoop", spawnTime, spawnDelay);

    }

    // Update is called once per frame
    void Update()
    {
        poops = GameObject.FindGameObjectsWithTag(("poop"));
        cuyes = GameObject.FindGameObjectsWithTag(("Cuy"));

        
        WhenToSpawn();
    }

    void SpawnPoop()
    {
        spawnTime += Time.deltaTime;
        if (spawnTime >= 5f)
        {
            foreach (GameObject cuy in cuyes)
            {
                StartCoroutine(cuy.GetComponent<AnimationController>().Poop());
            }
            spawnTime = 0;
        }     
    }

    void WhenToSpawn()
    {

        if (poops.Length <= cuyes.Length*2)
        {
            SpawnPoop();
            //InvokeRepeating("SpawnPoop", spawnTime, spawnDelay);
        }
    }

   
}
