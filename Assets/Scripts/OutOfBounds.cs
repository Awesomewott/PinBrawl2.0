using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    public GameObject newBall;
    public GameObject lifeOne;
    public GameObject lifeTwo;
    public GameObject lifeThree;
    public int lives = 3;

    GameController gameController = new GameController();
    private void OnCollisionEnter2D(Collision2D obj)
    {
        lives--;
        

        GameObject newObj = Instantiate(newBall);
            
        newObj.transform.position = new Vector3(Random.Range(-1.0f,1.0f), 5.01f, 0f);
            
        if(lives == 2)
        {
            Destroy(lifeOne);
        }
        else if(lives == 1)
        {
            Destroy(lifeTwo);
        }
        else if(lives == 0)
        {
            Destroy(lifeThree);
        }
        if(lives < 0)
        {
            OnDeath();
        }

        Destroy(obj.gameObject);
    }

    public void OnDeath()
    {
        Debug.Log("Dead"); 
        GameController.Instance.OnDeathScreen();
    }
}
