using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public Transform[] spawnpoints;
    public GameObject[] ememyPrefabs;
    public static bool spawnAllowed;

    void Start()
    {
        spawnAllowed = true;
        InvokeRepeating("SpawnMobs", 0f, 1f );
    }

    void SpawnMobs()
    {
        if (spawnAllowed)
        {
            int randEnemy = Random.Range(0, ememyPrefabs.Length);
            int randSpawPoint = Random.Range(0, spawnpoints.Length);

            Instantiate(ememyPrefabs[0], spawnpoints[randSpawPoint].position, transform.rotation);
        }
    }
    
    void Update()
    {
        
    }
}
