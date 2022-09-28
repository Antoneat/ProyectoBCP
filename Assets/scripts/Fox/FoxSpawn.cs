using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxSpawn : MonoBehaviour
{
    public PoopController pC;
    public GameObject fox;
    public GameObject spawnPoint;

    public GameObject[] foxes;
    [SerializeField] private float foxSpawnTime;
    [SerializeField] private float randomTime;
    void Start()
    {
        foxes = new GameObject[foxes.Length];
        RandomizeTimer();
    }

    // Update is called once per frame
    void Update()
    {
        foxes = GameObject.FindGameObjectsWithTag(("Fox"));

        if (pC.cuyes.Length >= 2)
        {
            foxSpawnTime += Time.deltaTime;
            if (foxSpawnTime >= (randomTime - 0.5f) && foxSpawnTime <= (randomTime + 0.5f))
            {
                foxSpawnTime = 0;
                Spawn();
            }

        }
        else
		{
            foxSpawnTime = 0;
		}
    }

    void RandomizeTimer()
	{
        randomTime = Random.Range(10f, 20f);
	}

    void Spawn()
    {
        Instantiate(fox, spawnPoint.transform.position, spawnPoint.transform.rotation);
        RandomizeTimer();
    }
}
