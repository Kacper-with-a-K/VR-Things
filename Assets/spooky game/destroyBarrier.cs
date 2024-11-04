using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyBarrier : MonoBehaviour
{
    public barrier barrier;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void destroyBarriers()
    {
        barrier.barrierAlive = false;
    }
}
