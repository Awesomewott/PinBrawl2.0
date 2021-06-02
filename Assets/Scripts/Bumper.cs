using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{

    public int bumperForce = 800;
    private GameObject player;
    private Rigidbody2D bumper;

    public Animator animator;

    void Start()
    {

        Debug.Log("I was touched");
        player = GameObject.FindGameObjectWithTag("Player");

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetTrigger("Hit");
        animator.SetTrigger("Hit2");
        animator.SetTrigger("Hit3");
        animator.SetTrigger("Hit4");
        animator.SetTrigger("Hit5");
        animator.SetTrigger("Hit6");
        animator.SetTrigger("Hit7");
        collision.rigidbody.AddForce(-collision.GetContact(0).normal * 15, ForceMode2D.Impulse);
    }
}
