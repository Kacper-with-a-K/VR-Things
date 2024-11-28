using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{

    public GameObject Flame;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void startFire()
    {
        Flame.SetActive(true);
    }

    public void stopFire()
    {
        Flame.SetActive(false);
    }
}
