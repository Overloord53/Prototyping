using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemys : MonoBehaviour
{
    public float speed = 7f;
    
    
    
    void Start()
    {
        OnWave();
    }
    
    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * speed;
        
        
    }
    
    public void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    public void OnWave()
    {
        if (ScoreScript.scoreValue >= 100)
        {
            speed++;
        }
    }
    
  
}