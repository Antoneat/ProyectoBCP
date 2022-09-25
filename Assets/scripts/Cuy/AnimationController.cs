using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private PoopController poopC;
    [SerializeField] private HungerController hungerC;
    [SerializeField] private bool sad;


    [SerializeField] private GameObject suciom;
    [SerializeField] private GameObject hambrem;
    // Start is called before the first frame update
    void Start()
    {
        poopC = GameObject.Find("DirtPoopManager").GetComponent<PoopController>();
        hungerC = gameObject.GetComponent<HungerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(poopC.poops.Length >= poopC.cuyes.Length*2)
		{
            suciom.SetActive(true);
		}else
		{
            suciom.SetActive(false);
		}
        if(hungerC.hunger > 7.5f)
		{
            hambrem.SetActive(true);
		}else
		{
            hambrem.SetActive(false);
		}
        if((poopC.poops.Length >= poopC.cuyes.Length*2) || hungerC.hunger > 7.5f)
		{
            sad = true;
		}else
		{
            sad = false;
		}
        anim.SetFloat("Speed", Mathf.Abs(rb.velocity.x) + Mathf.Abs(rb.velocity.y));
        anim.SetBool("Sad", sad);
    }
}
