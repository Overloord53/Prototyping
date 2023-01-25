using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPowerupSpawner : MonoBehaviour
{
    public Transform[] spawnpoints;
    public GameObject[] ememyPrefabs;
    
    public static bool spawnAllowed;
    
    
    void Start()
    {
        
        spawnAllowed = true;
        InvokeRepeating("SpawnMobs", 10f, 15f );
      
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
