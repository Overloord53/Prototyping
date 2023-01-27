using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Licht_Aus : MonoBehaviour
{
    public Animator animator;


    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Zunge"))
        {
            animator.SetTrigger("Lichtaus");
        }
    }
}
