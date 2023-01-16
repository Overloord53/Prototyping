using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public float currenthealth { get; private set; }
   
    void Start()
    {
        currenthealth = maxHealth;
        GetComponent<ScoreScript>();
    }

    private void Update()
    {
        
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
