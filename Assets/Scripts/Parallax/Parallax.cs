using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float speed = 1f;

    public float clamppos;

    public Vector3 Startposition;
    void Start()
    {
        Startposition = transform.position;
    }

    void Update()
    {
        float NewPosition = Mathf.Repeat(Time.time * speed, clamppos);
        transform.position = Startposition + Vector3.down * NewPosition;
    }
}
