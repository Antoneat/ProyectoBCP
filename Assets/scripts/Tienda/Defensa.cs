using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defensa : MonoBehaviour
{
    [SerializeField] MoneyController mc;
    [SerializeField] FoxMovment fm;
    [SerializeField] GameObject Fox;
    void Start()
    {
        fm = Fox.GetComponent<FoxMovment>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuyDefensa()
    {
        if (mc.Money >= 20)
        {
            mc.Money -= 20;
            fm.mejorado = true;
        }
    }
}
