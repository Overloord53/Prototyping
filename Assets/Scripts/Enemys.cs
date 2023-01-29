using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemys : MonoBehaviour
{
    public float speed = 7f;
    
    
    
    void Start()
    {
        
    }
    
    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * speed;
        
    }
    
    public void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    
  
}