using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxMovment : MonoBehaviour
{
    private PoopController pC;
    private GameObject corral;

    [SerializeField] private float speed;
    GameObject currentPoint;

    private bool goingtocorral;
    private float breakinCorral;

    int index;
    void Start()
    {

        pC = GetComponent<PoopController>(); 
        corral = GameObject.FindGameObjectWithTag("Corral");

        index = Random.Range(0, pC.cuyes.Length);
        currentPoint = pC.cuyes[index];
        goingtocorral = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (goingtocorral)
        { 
            MoveToCorral();
        }
    }

    void MoveToCorral() // mueve el zorro hacia el corral
    {
        transform.position = Vector2.MoveTowards(transform.position, corral.transform.position, speed*Time.deltaTime);
        transform.up = corral.transform.position - transform.position;
    }

    void CatchCuy() // mueve el zorro hacia un cuy del array de cuys, elige el cuy a lo random
    {
        transform.position = Vector2.MoveTowards(transform.position,currentPoint.transform.position, speed * Time.deltaTime);
        transform.up = currentPoint.transform.position - transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Corral"))
        {
            goingtocorral = false;
            breakinCorral += Time.deltaTime;
            
            if (breakinCorral >= 6f)
            {
                CatchCuy();
                breakinCorral =0;
            }    
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Cuy"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);

        }
    }

}
