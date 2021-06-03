using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject theEnemy;
    public int xPos;
    public int yPos;
    public int EnemyCount;
    public float spawnTimer;
    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {

        do
        {
            //xPos = Random.Range(-350, 350);
            //yPos = Random.Range(-200, 200);
            Instantiate(theEnemy, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(spawnTimer);
            EnemyCount += 1;
            if (EnemyCount >= 10)
            {
                EnemyCount = 0;
            }

        } while (EnemyCount < 10);




    }
}
