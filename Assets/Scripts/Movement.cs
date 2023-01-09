using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10f;
    
    private float _startSpeed ;
    private Vector2 _moveInput;
    public string Axis;
    
  

    void Update()
    {
        _moveInput.y = Input.GetAxisRaw(Axis);

        transform.position += (Vector3) _moveInput * (speed * Time.deltaTime);
    }
}
