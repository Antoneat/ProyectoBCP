using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaldeScript : MonoBehaviour
{
    public Feeder feeder;
    public SpriteRenderer sr;
    public Sprite food1;
    public Sprite food2;
    public Sprite food3;
    public Sprite food4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(feeder.normal)
		{
            sr.sprite = food1;
		}
        if(feeder.mejora1)
		{
            sr.sprite = food2;
		}
        if(feeder.mejora2)
		{
            sr.sprite = food3;
		}
        if(feeder.mejora3)
		{
            sr.sprite = food4;
		}
    }
}
