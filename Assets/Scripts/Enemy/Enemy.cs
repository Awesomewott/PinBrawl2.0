using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject target;
    public GameObject player;
    public Transform bumper;
    public float moveSpeed = 30f;
    public Rigidbody2D rb;

    Vector2 movement;
    private void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();

        target = GameObject.FindGameObjectWithTag("Target");
        //Physics2D.IgnoreCollision()//bumper.GetComponent<Collider2D>(), GetComponent<Collider2D>(), true);
    }
    void Update()
    {
        Vector2 direction = target.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;
    }

    private void FixedUpdate()
    {
        MoveCharacter(movement);
    }

    public void MoveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.rigidbody.AddForce(-collision.GetContact(0).normal * 15, ForceMode2D.Impulse);
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "Bumper")
        {
            Physics2D.IgnoreCollision(collision.collider, GetComponent<CircleCollider2D>(), true);//bumper.GetComponent<Collider2D>(), GetComponent<Collider2D>(), true);
        }


    }
}
