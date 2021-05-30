using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flippers : MonoBehaviour
{

    public bool Flipper = false;

    // Update is called once per frame
    void Update()
    {
        if((Flipper && Input.GetKey(KeyCode.RightArrow)) || (!Flipper && Input.GetKey(KeyCode.LeftArrow)))
        {
            GetComponent<HingeJoint2D>().useMotor = true;
        }
        else
        {
            GetComponent<HingeJoint2D>().useMotor = false;
        }
    }
}
