using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //Collision collision;
    public TMP_Text scoreTxt;
    public int score;

    private void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Bumper")
        {
            score += 100;
            scoreTxt.text = score.ToString();
            Debug.Log(score);
        }
    }

}
