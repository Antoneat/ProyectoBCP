using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuyExtra : MonoBehaviour
{
    [SerializeField] MoneyController mc;
    [SerializeField] PoopController pc;
    [SerializeField] GameObject cuy;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuyCuy()
    {
        if(mc.Money>=20 && pc.cuyes.Length<6)
        {
            mc.Money -=20;
            //int randomIndex = Random.Range(0, myObjects.Length);
            //Vector2 randomSpawnPosition = new Vector2(Random.Range(-20, -21), Random.Range(-10, 11));

            Vector2 spawnPoint = new Vector2(-13, 6.1f);
            Instantiate(cuy,spawnPoint, Quaternion.identity);
        }
    }
}
