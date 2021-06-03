using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{

    public int bumperForce = 800;
    private GameObject player;
    private Rigidbody2D bumper;
<<<<<<< HEAD
=======
    //public TMP_Text scoreTxt;

    //public int score = 100;
>>>>>>> a5650f4d86fc6a039a014c581c5ff2fdaa9b2963

    public Animator animator;

    void Start()
    {

        Debug.Log("I was touched");
        player = GameObject.FindGameObjectWithTag("Player");

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
<<<<<<< HEAD
=======
        //scoreTxt.text = score.ToString();
        //Debug.Log(score);
        //Score.curScore += 100;
>>>>>>> a5650f4d86fc6a039a014c581c5ff2fdaa9b2963
        animator.SetTrigger("Hit");
        animator.SetTrigger("Hit2");
        animator.SetTrigger("Hit3");
        animator.SetTrigger("Hit4");
        animator.SetTrigger("Hit5");
        animator.SetTrigger("Hit6");
        collision.rigidbody.AddForce(-collision.GetContact(0).normal * 15, ForceMode2D.Impulse);
    }
}
