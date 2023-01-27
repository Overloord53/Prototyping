using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zunge : MonoBehaviour
{
   
    private Rigidbody2D myRigidbody2D;
    public Player player;
    public float speed = 10f;
    public Animator animator;
    public int damage;
    private int currentState;
    private bool isActive;
    public AudioSource audioPlayer;

    private void Awake()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }
    
    
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if(!isActive) animator.SetTrigger("ZungeTrigger");
            isActive = true;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            isActive = false;
            AnimationHandler();
        }
    }

    public void ChangeState(int state)
    {
        currentState = state;
    }
    
    private void AnimationHandler()
    {
        switch (currentState)
        {
            case 0:
                print("Kurz");
                animator.SetTrigger("ZungeKurz");
                break;
            case 1:
                print("Mittel");
                animator.SetTrigger("ZungeMittel");
                break;
            case 2:
                print("Lang");
                animator.SetTrigger("ZungeLang");
                break;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Mob"))
        {
            Mob mobhealth =  col.gameObject.GetComponent<Mob>();
            if (mobhealth != null)
            {
                mobhealth.TakeDamage(damage);
                audioPlayer.Play();
            }
        }
        if (col.gameObject.CompareTag("Mob"))
        {
            Mob2 mobhealth =  col.gameObject.GetComponent<Mob2>();
            if (mobhealth != null)
            {
                mobhealth.TakeDamage(damage);
                audioPlayer.Play();
            }
        }
       
       
        
        if (col.gameObject.CompareTag("Enemy"))
        {
            player.animator.SetTrigger("Schaden");
        }
    }
}
