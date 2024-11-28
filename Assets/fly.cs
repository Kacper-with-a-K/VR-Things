using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : MonoBehaviour
{
    Rigidbody rb;
    public float force = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.up * force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
