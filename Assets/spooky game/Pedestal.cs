using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedestal : MonoBehaviour
{
    public GameObject pedestal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivatePedestal()
    {
        pedestal.SetActive(true);
    }

    public void DeactivatePedestal()
    {
        pedestal.SetActive(false);
    }
}
