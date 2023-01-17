using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob : MonoBehaviour
{
    public int maxHealth = 2;
    public float currenthealth { get; private set; }
   
    
    
    
    void Start()
    {
        currenthealth = maxHealth;
    }
    
    public void TakeDamage(int damage)
    {
        currenthealth -= damage;
        if (currenthealth <= 0)
        {
            ScoreScript.scoreValue += 10;
            
            Destroy(gameObject);
            
        }
        
    }
    
    
    
    
    
    
}

