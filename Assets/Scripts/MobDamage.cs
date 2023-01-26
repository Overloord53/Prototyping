using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobDamage : MonoBehaviour
{
    public int damage;
    
    

    private void OnTriggerEnter2D(Collider2D col)
    {
     
        if (col.gameObject.CompareTag("Player"))
        {
            PlayerHealth playerHealth =  col.gameObject.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage);
                Destroy(gameObject);
            }

        }
        if (col.gameObject.CompareTag("Zunge"))
        {
            PlayerHealth playerHealth =  col.gameObject.GetComponentInParent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage);
            }

        }
       
    }
}
