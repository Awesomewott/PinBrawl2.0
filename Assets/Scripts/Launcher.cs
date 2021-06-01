using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{

    public bool isTouched = false;
    public bool isKeyPress = false;

    public bool isActive = true;

    private float pressTime = 0f;
    private float startTime = 0f;
    private int powerIndex;

    private SpringJoint2D springJoint;
    private Rigidbody2D rb;
    private float force = 0f;
    public float maxForce = 90f;

    bool isPrevKeyPress = false;

    // Start is called before the first frame update
    void Start()
    {
        springJoint = GetComponent<SpringJoint2D>();
        springJoint.distance = 1f;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            isKeyPress = true;
            Debug.Log("Pressed");
        }

        if (Input.GetKeyUp("space"))
        {
            isKeyPress = false;
            Debug.Log("Unpressed");
        }

        // held
        if (isKeyPress)
        {
            Debug.Log("Held");
            Vector3 position = transform.position;
            position.y -= 0.5f * Time.deltaTime;
            transform.position = position;
        }

        // release
        if (isKeyPress == false && isPrevKeyPress == true)
        {
            
        }


        isPrevKeyPress = isKeyPress;

        /*       if (isActive)
               {
                   if (Input.GetKeyDown("space"))
                   {
                       isKeyPress = true;
                       Debug.Log("Pressed");
                   }

                   if (Input.GetKeyUp("space"))
                   {
                       isKeyPress = false;
                       Debug.Log("Unpressed");
                   }

                   // on keyboard press or touch hotspot
                   if (isKeyPress == true && isTouched == false || isKeyPress == false && isTouched == true)
                   {
                       if (startTime == 0f)
                       {
                           startTime = Time.time;
                           //pullSound.Play();
                       }
                   }

                   // on keyboard release 
                   if (isKeyPress == false && isTouched == false && startTime != 0f)
                   {
                       // #1
                       force = powerIndex * maxForce;
                       //shootSound.Play();
                       // reset values & animation
                       pressTime = 0f;
                       startTime = 0f;
                       //efxLightRenderer.sprite = efxLightAniController.spriteSet[1];
                       while (powerIndex >= 0)
                       {
                           //efxZoomRenderer.sprite = efxZoomAniController.spriteSet[powerIndex];
                           powerIndex--;
                       }
                   }
               }*/
    }

    private void FixedUpdate()
    {
        // When force is not 0
        if (force != 0)
        {
            // release springJoint and power up
            springJoint.distance = 1f;
            rb.AddForce(Vector3.up * force);
            force = 0;
        }

        // When the plunger is held down
        if (pressTime != 0)
        {
            // retract the springJoint distance and reduce the power
            springJoint.distance = 0.8f;
            rb.AddForce(Vector3.down * 400);
        }
    }
}
