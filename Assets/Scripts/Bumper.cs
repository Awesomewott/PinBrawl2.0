using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Bumper : MonoBehaviour
{

    public int bumperForce = 800;
    private GameObject player;
    private Rigidbody2D bumper;
    //public TMP_Text scoreTxt;
      ParticleSystem particle;

    public int score = 100;

    public Animator animator;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        particle = GetComponent<ParticleSystem>();
        
    }
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //scoreTxt.text = score.ToString();
        //Debug.Log(score);
        animator.SetTrigger("Hit");
        animator.SetTrigger("Hit2");
        animator.SetTrigger("Hit3");
        animator.SetTrigger("Hit4");
        animator.SetTrigger("Hit5");
        animator.SetTrigger("Hit6");
        animator.SetTrigger("Hit7");
        particle.Play(true);
        collision.rigidbody.AddForce(-collision.GetContact(0).normal * 15, ForceMode2D.Impulse);
        

    }
}
