using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtyController : MonoBehaviour
{
    private float dirtyRun;
    public PoopController pC;
    // Start is called before the first frame update
    void Start()
    {
        Dirty();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Dirty()
    {
        if (pC.poops.Length >= pC.cuyes.Length * 2)
        {
            dirtyRun += Time.deltaTime;
            if (dirtyRun >= 5f)
            {
                foreach (GameObject cuy in pC.cuyes)
                {
                    Destroy(cuy);
                    dirtyRun = 0;
                }
            }
        }
    }
}
