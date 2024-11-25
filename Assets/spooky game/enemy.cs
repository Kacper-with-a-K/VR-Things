using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1 : MonoBehaviour
{
    public GameObject[] pattern;
    private int patternIndex = 0;
    public float speed;
    public float rotationSpeed = 5f;

    public bool spotted;

    public GameObject target;

    public GameObject RespawnTips;

    public AudioSource squeel;

    public AudioClip sound;

    public GameObject respawnTarget;
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        squeel = GetComponent<AudioSource>();
    }
    

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == target)
        {
            
            squeel.PlayOneShot(sound);
            spotted = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject == target)
        {
            spotted = false;
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == target)
        {
            RespawnTips.SetActive(true);
            target.transform.position = respawnTarget.transform.position;
        }
    }

    void Update()
    {
        if (anim != null)
        {
            anim.SetBool("walk", true);
        }

        if (spotted == false)
        {

            GameObject waypoint = pattern[patternIndex];

            // Vector towards waypoint
            Vector3 rangeToClose = waypoint.transform.position - transform.position;

            float distance = rangeToClose.magnitude;
            float speedDelta = speed * Time.deltaTime;

            // Check if waypoint has been reached
            if (distance <= speedDelta)
            {
                patternIndex++;
                if (patternIndex >= pattern.Length)
                {
                    patternIndex = 0;
                }

                waypoint = pattern[patternIndex];
                rangeToClose = waypoint.transform.position - transform.position;
            }

            Vector3 normalizedRangeToClose = rangeToClose.normalized;

            // Rotate to direction it is facing
            if (normalizedRangeToClose != Vector3.zero)
            {
                Quaternion targetRotation = Quaternion.LookRotation(normalizedRangeToClose) * Quaternion.Euler(0, 180, 0);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
            }

            Vector3 delta = speedDelta * normalizedRangeToClose;
            transform.Translate(delta, Space.World);
        }

        else if (spotted == true)
        {
            Vector3 rangeToClose = target.transform.position - transform.position;

            float distance = rangeToClose.magnitude;
            float speedDelta = speed * Time.deltaTime;
            Vector3 normalizedRangeToClose = rangeToClose.normalized;

            if (normalizedRangeToClose != Vector3.zero)
            {
                Quaternion targetRotation = Quaternion.LookRotation(normalizedRangeToClose) * Quaternion.Euler(0, 180, 0);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
            }
            Vector3 delta = speedDelta * normalizedRangeToClose;
            transform.Translate(delta, Space.World);

        }
    }
}