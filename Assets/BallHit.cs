using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class BallHit : MonoBehaviour
{
    public Rigidbody body;
    public AudioClip bounce;
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>();
    }

    public void OnCollisionEnter()
    {
        audio.PlayOneShot(bounce, body.velocity.magnitude);
    }
}
