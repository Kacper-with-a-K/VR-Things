using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalPedestal : MonoBehaviour
{
    public GameObject Player;

    public GameObject Door;
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
        Door.SetActive(false);
        Player.transform.localScale = new Vector3(1, 1, 1);
    }
}
