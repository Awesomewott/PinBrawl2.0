using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{

    //Light lightbumper;
    //ParticleSystem particles;
    //float wTimer;
    //float rTimer;

    public int bumperForce = 800;
    private GameObject player;
    private Rigidbody2D bumper;

    void Start()
    {
        //lightbumper = GetComponent<Light>();
        //particles = GetComponent<ParticleSystem>();
        //particles.Stop(true);

        Debug.Log("I was touched");
        player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    //void Update()
    //{
    //if (lightbumper.color == Color.blue)
    //{
    //    wTimer += Time.deltaTime; 
    //}

    //if (wTimer > 0.5)
    //{
    //    lightbumper.color = Color.white;
    //    wTimer = 0;
    //    particles.Stop(true);
    //}

    //if (lightbumper.color == Color.green)
    //{
    //    rTimer += Time.deltaTime;
    //}

    //if (rTimer > 0.5)
    //{
    //    lightbumper.color = Color.red;
    //    rTimer = 0;
    //    particles.Stop(true);
    //}

    //}

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
