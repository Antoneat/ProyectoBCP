using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnWaiting : MonoBehaviour
{
    [SerializeField] private UnityEvent OnDelayCompleted = new UnityEvent();
    [SerializeField] private bool OnStart;
    [SerializeField] private float DelayAmount;

    // Start is called before the first frame update
    void Start()
    {
        if(OnStart)
		{
            StartCoroutine(TimeDelay());
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DelayStart() => StartCoroutine(TimeDelay());

    IEnumerator TimeDelay()
	{
        yield return new WaitForSeconds(DelayAmount);
        OnDelayCompleted?.Invoke();
	}
}
