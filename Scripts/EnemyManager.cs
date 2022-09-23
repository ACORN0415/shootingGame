using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    float currentTime;
    public float createTIme =1;
    public GameObject enemyFactory;
    float minTime = 1;
    float maxTime = 5;
    void Start()
    {
        createTIme = UnityEngine.Random.Range(minTime, maxTime);    
    }
    void Update()
    {
        currentTime += Time.deltaTime;
        if(currentTime>createTIme)
        {
            GameObject enemy = Instantiate(enemyFactory);
            enemy.transform.position = transform.position;
            currentTime = 0;
            createTIme = UnityEngine.Random.Range(minTime, maxTime);
        }
    }
}
