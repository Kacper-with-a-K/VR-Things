using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openBook : MonoBehaviour
{
    public GameObject cover;
    public HingeJoint joint;
    // Start is called before the first frame update
    void Start()
    {
        var joint = cover.GetComponent<HingeJoint>();

        joint.useMotor = false;
    }

    // Update is called once per frame
    public void Open()
    {
        joint.useMotor = true;

    }

    public void Close()
    {
        joint.useMotor = false;
    }
}
