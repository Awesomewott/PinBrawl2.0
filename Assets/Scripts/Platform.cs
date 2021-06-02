using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{

    public float timeLeft = 3;
    public float speed = 2;
    public GameObject platform;

    void Update()
    {
        if (timeLeft >=3)
        {
            timeLeft -= Time.deltaTime;
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else if (timeLeft <= -3)
        {
            timeLeft += Time.deltaTime;
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }




    }

}
