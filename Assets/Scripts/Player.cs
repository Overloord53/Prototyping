using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    
    private float _startSpeed ;
    private Vector2 _moveInput;
    public string Axis;
    
  

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
    }
}