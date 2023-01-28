using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plus_Health_PowerUp : MonoBehaviour
{
    public PlayerHealth PlayerHealth;
    public int zb = 3;
    

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Powerup"))
        {
            if (PlayerHealth.currenthealth <= PlayerHealth.maxHealth)
            {
                PlayerHealth.currenthealth++;
            }
            if (PlayerHealth.currenthealth >= 4)
            {
                PlayerHealth.currenthealth = PlayerHealth.maxHealth;
            }
            
            
           
        }
        
        if (col.gameObject.CompareTag("Zunge"))
        {

            Destroy(gameObject);

        }
       
    }
}
