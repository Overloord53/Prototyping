using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;


public class Player : MonoBehaviour
{
    
    public float speed = 10f;
    private Rigidbody2D myRigidbody2D;
    private float _startSpeed ;
    private Vector2 _moveInput;
    public string Axis;
    public Animator animator;
    private bool spacekeyState;
    public int desiredLane = 1;
    public float laneDistance = 10.5f;
    private Vector3 spawnPos;
    


    private void Awake()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        spawnPos = transform.position;
    }

    void Update()
    {
        
        spacekeyState = Input.GetKey(KeyCode.Space);

        animator.SetBool("Auf", spacekeyState);

        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetTrigger("Drop");
            desiredLane++;
            if (desiredLane==3)
            {
                desiredLane = 2;
            }
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("Sprung");
            desiredLane--;
            if (desiredLane==-1)
            {
                desiredLane = 0;
            }
        }

        Vector3 targetPosition = spawnPos;
        if (desiredLane == 0)
        {
            targetPosition += Vector3.up * laneDistance;
        }
        else if (desiredLane == 2)
        {
            targetPosition += Vector3.down * laneDistance;
        }

        transform.position = targetPosition;
        
        
        
       
        
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Mob")) 
        {
            {
                LaunchMouth();
            }
            
        }

        if (col.gameObject.CompareTag("Enemy"))
        {
            animator.SetTrigger("Schaden");
        }
        if (col.gameObject.CompareTag("Enemy2"))
        {
            animator.SetTrigger("Schaden");
        }
      
        
        

    }
    private void LaunchMouth()
    {
        animator.SetTrigger("MundAuf");
    }
    
   
    
    
}
