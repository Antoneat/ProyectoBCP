using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideShop : MonoBehaviour
{

    public GameObject panelTienda;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowShop()
    {
        if (!panelTienda.activeInHierarchy)
        {
            panelTienda.SetActive(true);           
        }
    }

    public void HideShop()
    {
        panelTienda.SetActive(false);
    }
}
