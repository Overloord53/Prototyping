using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField]
    private GameObject spiderwebPrefab;
    [SerializeField]
    private Animator _animator;
    [SerializeField]
    private Transform mouth;



    public void stopAttack()
    {
        _animator.SetBool("Attack", false);
    }
     
    public void Shoot()
    {
        GameObject go = Instantiate(spiderwebPrefab, mouth.position, quaternion.identity);
        Vector3 direcion = new Vector3(transform.localScale.x, 0);
        go.GetComponent<Projectile>().Setup(direcion);
    }

    private void Update()
    {
        _animator.SetBool("Attack", true);
    }
}
