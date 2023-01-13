using System.Collections;
using System.Collections.Generic;
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
    
    
    
    
    private void Awake()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }
    
  

    void Update()
    {
        _moveInput.y = Input.GetAxisRaw(Axis);

        transform.position += (Vector3) _moveInput * (speed * Time.deltaTime);

        if (transform.position.y > 29)
        {
            transform.position += Vector3.down * Time.deltaTime * speed;
        }

        if (transform.position.y < 2)
        {
            transform.position += Vector3.up * Time.deltaTime * speed;
        }
        
        if (myRigidbody2D.velocity == Vector2.zero)
        {
            spacekeyState = Input.GetKeyDown(KeyCode.Space);
            if (spacekeyState == true)
            {
                LaunchMouth();
            } 
        }
        
        
    }
    private void LaunchMouth()
    {
        animator.SetTrigger("Auf");
    }
   
}
