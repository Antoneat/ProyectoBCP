using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxMovment : MonoBehaviour
{

    Rigidbody2D rb;
    Transform target;
    [SerializeField] private PoopController poopc;
    Vector2 moveDirection;
    [SerializeField] private float speed;
    [SerializeField]  GameObject cuy;

    public float breakinCorral;
    public bool mejorado;
    public FoxAnimation foxanim;
    public GameObject sprite;

    [SerializeField] private Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = sprite.GetComponent<Animator>();
       
       // cuy = GameObject.FindGameObjectWithTag("Cuy");
       mejorado = false;
    }


    void Update()
    {
        if (!poopc)
        {
            poopc = GameObject.Find("DirtPoopManager").GetComponent<PoopController>();
            target = poopc.cuyes[1].transform;
        }
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
        anim.SetBool("Rompiendo", true);
        breakinCorral += Time.deltaTime;
        Vector2 direction = (target.position - transform.position).normalized;
        float angle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg;
        moveDirection = direction;

        if (breakinCorral >= 6f)
        {
            anim.SetBool("Rompiendo", false);
            anim.SetBool("Corriendo", true);
            rb.velocity = new Vector2(moveDirection.x, moveDirection.y)*speed;
            breakinCorral = 0;
        }

    }

    void CatchCuyDefensa()
    {
        anim.SetBool("Rompiendo", true);
        Debug.Log("foxeando2");
        breakinCorral += Time.deltaTime;
        Vector2 direction = (target.position - transform.position).normalized;
        float angle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg;
        moveDirection = direction;

        if (breakinCorral >= 12f)
        {
            anim.SetBool("Rompiendo", false);
            anim.SetBool("Corriendo", true);
            rb.velocity = new Vector2(moveDirection.x, moveDirection.y) * speed;
            breakinCorral = 0;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Cuy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            //foxanim.cuyToKill = collision.gameObject;
            //anim.SetBool("Corriendo", false);
            //anim.SetBool("Comer", true);
        }
    }


}
