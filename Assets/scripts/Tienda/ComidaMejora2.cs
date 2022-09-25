using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComidaMejora2 : MonoBehaviour
{
    [SerializeField] MoneyController mc;
    [SerializeField] Feeder feed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuyMejora2()
    {
        if (mc.Money >= 25 && feed.mejora1 == true)
        {
            mc.Money -= 25;
            feed.normal = false;
            feed.mejora1 = false;
            feed.mejora2 = true;
        }
    }
}
