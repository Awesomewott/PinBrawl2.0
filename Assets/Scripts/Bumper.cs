using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{

    public int bumperForce = 800;
    private GameObject player;
    private Rigidbody2D bumper;

    void Start()
    {

        Debug.Log("I was touched");
        player = GameObject.FindGameObjectWithTag("Player");

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if (lightbumper.color == Color.white)
        //{
        //    lightbumper.color = Color.blue;
        //}

        //if (lightbumper.color == Color.red)
        //{
        //    lightbumper.color = Color.green;
        //}

        //particles.Play(true);
        collision.rigidbody.AddForce(-collision.GetContact(0).normal * 15, ForceMode2D.Impulse);
    }

    //public void OnTriggerEnter2D(Collider collider)
    //{
    //    if (collider.gameObject == player)
    //    {
    //        player.GetComponent<Rigidbody>().AddExplosionForce(bumperForce, transform.position, 1);
    //    }
    //}

    //public void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.gameObject == player)
    //    {
    //        player.GetComponent<Rigidbody2D>().AddForce(transform.forward, ForceMode2D.Impulse);//.(bumperForce, transform.position)//.AddForce.AddExplosionForce(bumperForce, transform.position, 1);
    //    }
    //}
}
