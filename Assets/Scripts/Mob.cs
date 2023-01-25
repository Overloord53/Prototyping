using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class Mob : MonoBehaviour
{
    public int maxHealth = 2;
    public Animator anim;
    public float currenthealth { get; private set; }


    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

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
            anim.SetTrigger("Die");
            Destroy(gameObject, 0.1f);
            
        }
        
    }
    
    
    
    
    
    
    
}

