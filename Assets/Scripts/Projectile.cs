using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
  [SerializeField]
   private float speed;
   private Vector2 direction;
   [SerializeField]
   private string targetTag;

   public int damage;
   private void Update()
   {
       transform.Translate(direction * speed * Time.deltaTime);
   }

   public void Setup(Vector2 direction)
   {
       this.direction = direction;
   }

   public void OnBecameInvisible()
   {
       Destroy(gameObject);
   }

   private void OnTriggerEnter2D(Collider2D col)
   {
       if (col.gameObject.CompareTag("Player"))
       {
           PlayerHealth playerHealth =  col.gameObject.GetComponent<PlayerHealth>();
           if (playerHealth != null)
           {
              Destroy(gameObject);
              playerHealth.TakeDamage(damage);
           }

       }
   }
   
   
}



