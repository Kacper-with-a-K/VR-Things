using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fusebox : MonoBehaviour
{
    public GameObject Player;

    public GameObject FlashLight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void makeSmall()
    {
        Player.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        FlashLight.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
    }
}
