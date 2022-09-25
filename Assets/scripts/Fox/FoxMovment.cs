using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxMovment : MonoBehaviour
{

    Rigidbody2D rb;
    Transform target;
    Vector2 moveDirection;
    [SerializeField] private float speed;
    [SerializeField]  GameObject cuy;

    public float breakinCorral;
    public bool mejorado;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Cuy").transform;
        rb = GetComponent<Rigidbody2D>();
       
       // cuy = GameObject.FindGameObjectWithTag("Cuy");
       mejorado = false;
    }


    void Update()
    {
        if(mejorado==false)
        {

            CatchCuy();
        }
        else
        {
            CatchCuyDefensa();
        }


    }

    void CatchCuy()
    {
        Debug.Log("foxeando");
        breakinCorral += Time.deltaTime;
        Vector2 direction = (target.position - transform.position).normalized;
        float angle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg;
        rb.rotation = angle;
        moveDirection = direction;

        if (breakinCorral >= 6f)
        {
            rb.velocity = new Vector2(moveDirection.x, moveDirection.y)*speed;
            breakinCorral = 0;
        }

    }

    void CatchCuyDefensa()
    {
        Debug.Log("foxeando2");
        breakinCorral += Time.deltaTime;
        Vector2 direction = (target.position - transform.position).normalized;
        float angle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg;
        rb.rotation = angle;
        moveDirection = direction;

        if (breakinCorral >= 12f)
        {
            rb.velocity = new Vector2(moveDirection.x, moveDirection.y) * speed;
            breakinCorral = 0;
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
