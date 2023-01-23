using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMobSpawner : MonoBehaviour
{
    public Transform[] spawnpoints;
    public GameObject[] ememyPrefabs;
    public static bool spawnAllowed;
    public int spawnLimit = 5;
    public int spawned;
    
    void Start()
    {
        spawned = 0;
        spawnAllowed = true;
        InvokeRepeating("SpawnMobs", 2f, 30f );
    }

    void SpawnMobs()
    {
        if (spawnAllowed)
        {
            
            int randEnemyindex = Random.Range(0, ememyPrefabs.Length);
            int randSpawPoint = Random.Range(0, spawnpoints.Length);
            

            Instantiate(ememyPrefabs[randEnemyindex], spawnpoints[randSpawPoint].position, transform.rotation);



        }
    }
    
  
}
