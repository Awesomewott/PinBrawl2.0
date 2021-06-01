using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kicker : MonoBehaviour
{
    //public AudioSource kickout;
    //public AudioSource kickout2;
    float timer = 0;
    float hit;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<PointEffector2D>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(GetComponent<PointEffector2D>().enabled == true)
        {
            timer += Time.deltaTime;
        }
        if(timer > 3)
        {
            GetComponent<PointEffector2D>().enabled = false;
            //kickout2.Play();
            timer = 0;
        }
    }

     void OnTriggerEnter2D(Collider2D collision)
    {
        if(hit > 0)
        {
            GetComponent<PointEffector2D>().enabled = true;
            //kickout.Play();
            hit = 0;
        }
        else
        {
            hit++;
        }
    }
}
