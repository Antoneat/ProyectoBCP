using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuyController : MonoBehaviour
{
    Rigidbody2D rb;
    private Vector2 moveDirection;

    private string behaviour;
    private bool needsNewBehaviour = true;
    private bool currentlyMoving = false;
    private bool currentlyIdling = false;

    // Used to make the pig play a variety of oinking sound effects.
   // private AudioSource cuyAudioSource;
   // public List<AudioClip> cuySounds;

    // Floats used to process the pig's move behaviour.
    public float moveSpeed;
    private float moveLength;
    public float moveLengthMin;
    public float moveLengthMax;
    private float moveTime;
    public float moveDist;
   

    // Floats used to process the pig's idle behaviour.
    public float idleMin;
    public float idleMax;
    private float idleLength;
    private float idleTime;

    // Sprite Renderer
    public SpriteRenderer cuySpriteRenderer;

    // Animator
   // public Animator cuyAnimator;

    private void Start()
    {
  
        rb = GetComponent<Rigidbody2D>();
        // cuyAudioSource = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        if (needsNewBehaviour)
        {
            behaviour = ChooseBehaviour();
            needsNewBehaviour = false;
        }
        switch (behaviour)
        {
           /* case "cuySonidos":
                if (!cuyAudioSource.isPlaying)
                {
                    int cuySound = Random.Range(0, cuySounds.Count);
                    cuyAudioSource.PlayOneShot(cuySounds[cuySound]);
                    Debug.Log("The cuy cuyed(?? at " + Time.time);
                }
                needsNewBehaviour = true;

                break;*/

            case "move":
                if (!currentlyMoving)
                {
                    moveTime = 0;
                    moveLength = Random.Range(moveLengthMin, moveLengthMax);
                    rb.velocity = new Vector2(Random.Range(-moveDist, moveDist), Random.Range(-moveDist, moveDist)*moveSpeed);
                    //moveDirection = new Vector2(Random.Range(-moveDist, moveDist), Random.Range(-moveDist, moveDist));
                    Debug.Log("The cuy started moving at " + Time.time);
                    currentlyMoving = true;
                }
                if (moveTime < moveLength)
                {
                    if (rb.velocity.x < 0)
                    { cuySpriteRenderer.flipX = true; }
                    else if (rb.velocity.x > 0)
                    { cuySpriteRenderer.flipX = false; }
                    
                   
                    // rb.MovePosition(rb.position * moveDirection * Time.deltaTime * moveSpeed);
                    //transform.Translate(moveDirection * moveSpeed * Time.deltaTime);

                    moveTime += Time.deltaTime;
                    // cuyAnimator.SetFloat("Speed_f", 1);
                }
                else
                {
                    Debug.Log("The cuy finished moving at " + Time.time);
                    currentlyMoving = false;
                    needsNewBehaviour = true;
                  //  cuyAnimator.SetFloat("Speed_f", 0);
                }
                break;

            case "idle":

                if (!currentlyIdling)
                {
                    idleTime = 0;
                    idleLength = Random.Range(idleMin, idleMax);
                    Debug.Log($"The cuy is going to start idling at {Time.time} for {idleLength} seconds.");
                    currentlyIdling = true;
                }

                if (idleTime < idleLength)
                {
                    idleTime += Time.deltaTime;
                }
                else
                {
                    Debug.Log("The cuy finished idling at" + Time.time);
                    currentlyIdling = false;
                    needsNewBehaviour = true;
                }
                break;
        }
    }
    // Randomly returns one of several strings describing a possible piggy behaviour.
    string ChooseBehaviour()
    {
        int behaviour = Random.Range(0, 2);
        switch (behaviour)
        {
            case 0:
                return "move";
         /*   case 1:
                return "cuySonidos";*/
            default:
                return "idle";
        }
    }

}
