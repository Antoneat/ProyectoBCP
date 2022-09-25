using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PoopHUD : MonoBehaviour
{
    [SerializeField] private MoneyController poop;
    [SerializeField] private TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = poop.Money.ToString();
    }
}
