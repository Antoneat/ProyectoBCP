using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxSpawn : MonoBehaviour
{
    public PoopController pC;
    public GameObject fox;
    public GameObject spawnPoint;

    public GameObject[] foxes;
    private float foxSpawnTime;
    void Start()
    {
        foxes = new GameObject[foxes.Length];
    }

    // Update is called once per frame
    void Update()
    {
        foxes = GameObject.FindGameObjectsWithTag(("fox"));

        if (pC.cuyes.Length >= 2)
        {
            foxSpawnTime += Time.deltaTime;
            if (foxSpawnTime == Random.Range(10f, 20f))
            {
                foxSpawnTime = 0;
                Spawn();
            }

        }
    
    }

    void Spawn()
    {
        Instantiate(fox, spawnPoint.transform.position, spawnPoint.transform.rotation);
    }
}
