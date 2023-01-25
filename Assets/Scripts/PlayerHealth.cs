using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public float currenthealth;
   
    void Start()
    {
        currenthealth = maxHealth;
        GetComponent<ScoreScript>();
    }

    public void TakeDamage(int damage)
    {
        currenthealth -= damage;
        if (currenthealth <= 0)
        {
            ScoreScript.scoreValue = 0;
            Destroy(gameObject);
            SceneManager.LoadScene("LooseScreen");
            
        }
    }
}
