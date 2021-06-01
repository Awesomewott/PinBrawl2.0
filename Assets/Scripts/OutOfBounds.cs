using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    public GameObject newBall;

    private void OnCollisionEnter2D(Collision2D obj)
    {
        
            Destroy(obj.gameObject);

            GameObject newObj = Instantiate(newBall);
            
            newObj.transform.position = new Vector3(0.87f, 5.01f, 0f);

        
    }
}
