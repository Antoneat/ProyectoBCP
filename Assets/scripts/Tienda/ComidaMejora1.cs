using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComidaMejora1 : MonoBehaviour
{

    [SerializeField] MoneyController mc;
    [SerializeField] Feeder feed;
    [SerializeField] GameObject nextUpgrade;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuyMejora1()
    {
        if (mc.Money >= 10)
        {
            mc.Money -= 10;
            feed.normal = false;
            feed.mejora1 = true;
            nextUpgrade.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}
