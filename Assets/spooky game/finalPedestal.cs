using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalPedestal : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void makeBig()
    {
        Player.transform.localScale = new Vector3(1, 1, 1);
    }
}
