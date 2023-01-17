using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zunge : MonoBehaviour
{
   
    private Rigidbody2D myRigidbody2D;
    private bool spacekeyState;
    public Player player;
    public float speed = 10f;
    public Animator animator;
    public int damage;
    
    

    
    private void Awake()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }
    
    
    private void Update()
    {

        spacekeyState = Input.GetKey(KeyCode.Space);

        animator.SetBool("Zunge", spacekeyState);
       
        
        

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Mob"))
        {
            Mob mobhealth =  col.gameObject.GetComponent<Mob>();
            if (mobhealth != null)
            {
                mobhealth.TakeDamage(damage);
            }

        }
    }
   

    

   

    
    
   

    

    
}
