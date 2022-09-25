using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuyDorado : MonoBehaviour
{
    [SerializeField] MoneyController mc;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuyCuyD()
    {
        if (mc.Money >= 100)
        {
            Debug.Log("ganaste");
        }
    }
}
