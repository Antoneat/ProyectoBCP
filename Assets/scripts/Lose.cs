using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class    WinLoseController : MonoBehaviour
{

    MoneyController mc;
    PoopController pc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(mc.Money <=0 && pc.cuyes==null)
        {
            SceneManager.LoadScene("Lose");
        }
    }
}
