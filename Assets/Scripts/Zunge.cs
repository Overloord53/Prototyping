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
    
    

    
    private void Awake()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }
    
    
    private void Update()
    {

       


        if (myRigidbody2D.velocity == Vector2.zero)
        {
            spacekeyState = Input.GetKeyDown(KeyCode.Space);
            if (spacekeyState == true)
            {
                LaunchTongue();
            } 
        }
        
       

       
        
    }

    private void LaunchTongue()
    {
        animator.SetTrigger("Zunge");
    }
    
   

    

    
}
