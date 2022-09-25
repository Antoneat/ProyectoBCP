using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoopValue1 : MonoBehaviour
{
    private MoneyController mc;
    [SerializeField] private float value;
    void Start()
    {
        mc = GameObject.Find("MoneyManager").GetComponent<MoneyController>();
        RandomPoopValue(); 
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void plusMoney()
    {
        mc.Money += value;
    }
    void RandomPoopValue()
    {
        int i = Random.Range(1, 6);

        if (i <= 2)
        {
            value = 2;
        }
        else if (i == 3 || i == 4)
        {
            value = 1;
        }
        else if (i == 5)
        {
            value =3;
        }

    }
}

