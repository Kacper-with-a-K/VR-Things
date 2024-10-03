using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHit : MonoBehaviour
{
    public Rigidbody body;
    public AudioClip bounce;
    AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter()
    {
        audio.PlayOneShot(bounce, body.velocity.magnitude);
    }
}
