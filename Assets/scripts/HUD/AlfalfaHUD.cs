using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AlfalfaHUD : MonoBehaviour
{
    [SerializeField] private FoodCounter foodC;
    [SerializeField] private TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = foodC.foodValue.ToString();
    }
}
