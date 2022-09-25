using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WinloseController : MonoBehaviour
{
    [SerializeField] MoneyController mc;
    [SerializeField] PoopController pc;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Lost();
        Won();
    }

    void Lost()
    {
        if (mc.Money <= 0 && pc.cuyes.Length==0)
        {
            SceneManager.LoadScene("Lose");
        }
    }

    void Won()
    {
        if (mc.Money >= 100)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
