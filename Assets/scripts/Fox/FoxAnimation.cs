using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxAnimation : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject cuyToKill;
    public GameObject effect;
    public GameObject nest;
    public bool run;
    // Start is called before the first frame update
    void Start()
    {
        nest = GameObject.FindGameObjectWithTag("Nest");
    }

    // Update is called once per frame
    void Update()
    {
        if (run)
        {
            rb.MovePosition(nest.transform.position);
        }
    }

    public void Killcuy()
    {
        Destroy(cuyToKill);
    }
    public void Disappear()
    {
        if (effect)
        {
            GameObject obj = Instantiate(effect);
            Destroy(obj, 1f);
        }
        Destroy(gameObject);
    }
}
