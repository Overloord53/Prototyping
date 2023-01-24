using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class RandomSpawner : MonoBehaviour
{
    public Transform[] spawnpoints;
    public GameObject[] ememyPrefabs;

    public float EnemyInterval = 3f;
    public int maxEnemies = 3;
    private int currentEnemies = 0;
    
    
    void Start()
    {
        StartCoroutine(SpawnEnemys());
    }

    private IEnumerator SpawnEnemys()
    {
        while (true)
        {
            if (currentEnemies < maxEnemies)
            {
                
                yield return new WaitForSeconds(GetInterval());
            
                int randSpawPoint = Random.Range(0, spawnpoints.Length);
                int randEnemyindex = Random.Range(0, ememyPrefabs.Length);
                Instantiate(ememyPrefabs[randEnemyindex], spawnpoints[randSpawPoint].position, transform.rotation);
                
            }
        }
    }

    public float GetInterval()
    {
        
        if (ScoreScript.scoreValue >= 100)
        {
            return 2;
        }

        return EnemyInterval;
    }

   

    
}
