using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public Transform[] spawnpoints;
    public GameObject[] ememyPrefabs;
    public static bool spawnAllowed;
    public int spawnLimit = 5;
    public int spawned;
    
    void Start()
    {
        spawnAllowed = true;
        InvokeRepeating("SpawnMobs", 8f, 10f );
    }

    void SpawnMobs()
    {
        if (spawnAllowed)
        {
            if (spawned <= spawnLimit)
            {
                spawned++;
            }
            int randEnemyindex = Random.Range(0, ememyPrefabs.Length);
            int randSpawPoint = Random.Range(0, spawnpoints.Length);
            

            Instantiate(ememyPrefabs[randEnemyindex], spawnpoints[randSpawPoint].position, transform.rotation);



        }
    }
    
    
}
