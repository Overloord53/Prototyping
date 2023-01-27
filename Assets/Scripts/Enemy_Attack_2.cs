using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Attak_2 : MonoBehaviour
{
    [SerializeField]
    private GameObject BlitzschussPrefab;
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
        GameObject go = Instantiate(BlitzschussPrefab, mouth.position, Quaternion.identity);
        Vector3 direcion = new Vector3(transform.localScale.x, 0);
        go.GetComponent<Projectile>().Setup(direcion);
    }

    private void Update()
    {
        _animator.SetBool("Attack", true);
    }
}
