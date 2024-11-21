using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fusebox : MonoBehaviour
{
    public GameObject Player;

    public GameObject FlashLight;

    public GameObject gems;

    public GameObject tips;

    public GameObject smallTips;

    public Manager manager;

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
        tips.SetActive(false); 
        smallTips.SetActive(true);
        gems.SetActive(true);
        manager.small = true;
        Player.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        FlashLight.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
    }
}
