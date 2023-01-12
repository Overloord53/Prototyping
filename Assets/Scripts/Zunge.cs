using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zunge : MonoBehaviour
{
   
    private Rigidbody2D myRigidbody2D;
    private bool spacekeyState;
    public Player player;
    public float speed = 5f;
    

    
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
        
        if (myRigidbody2D.velocity == Vector2.zero)
        {
            spacekeyState = Input.GetKeyUp(KeyCode.Space);
            if (spacekeyState == true)
            {
                ResetTongue();
            } 
        }
        
    }

    private void LaunchTongue()
    {
        transform.position += Vector3.right * speed;
    }

    private void ResetTongue()
    {
        transform.position += Vector3.left * speed;
    }

    
}
