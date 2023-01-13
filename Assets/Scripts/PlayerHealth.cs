using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public float currenthealth { get; private set; }
   
    void Start()
    {
        currenthealth = maxHealth;
    }

    private void Update()
    {
        
    }


    public void TakeDamage(int damage)
    {
        currenthealth -= damage;
        if (currenthealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
