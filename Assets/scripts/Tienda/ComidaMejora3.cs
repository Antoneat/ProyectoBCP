using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComidaMejora3 : MonoBehaviour
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

    public void BuyMejora3()
    {
        if (mc.Money >= 45 && feed.mejora2 == true)
        {
            mc.Money -= 45;
            feed.normal = false;
            feed.mejora1 = false;
            feed.mejora2 = false;
            feed.mejora3 = true;
        }
    }
}
