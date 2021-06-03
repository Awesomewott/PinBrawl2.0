using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperController : MonoBehaviour
{

    public bool Flipper;
    public AudioSource flipperSound;
    // Update is called once per frame
    void Update()
    {
        if((Flipper && Input.GetKey(KeyCode.RightArrow)) || (!Flipper && Input.GetKey(KeyCode.LeftArrow)))
        {
            GetComponent<HingeJoint2D>().useMotor = true;
            flipperSound.Play();

        }
       
        else
        {
            GetComponent<HingeJoint2D>().useMotor = false;
        }
    }
}
