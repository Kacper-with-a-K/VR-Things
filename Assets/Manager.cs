using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject FlashLight;

    public Boolean small = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (small == true)
        {
            FlashLight.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        }
        else if(small == false)
        {
            FlashLight.transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }
}
