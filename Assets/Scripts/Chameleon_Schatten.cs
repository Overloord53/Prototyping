using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chameleon_Schatten : MonoBehaviour
{
    public Vector2 offset = new Vector2(0,15.5f);
    
    
    private SpriteRenderer sprRndCaster;
    private SpriteRenderer sprRndShadow;

    private Transform transcaster;
    private Transform transshadow;

    private void Start()
    {
        transcaster = transform;
        transcaster.name = "Player";
        transshadow = new GameObject().transform;
        transshadow.parent = transcaster;
        transshadow.gameObject.name = "shadow";
        transshadow.localScale = new Vector3(1,1,1);
        transshadow.localPosition = offset;
        
        
        sprRndCaster = GetComponent<SpriteRenderer>();
        sprRndShadow = transshadow.gameObject.AddComponent<SpriteRenderer>();
        sprRndShadow.sortingOrder = sprRndCaster.sortingOrder - 1;
        sprRndShadow.color = new Color(0, 0, 0, 0.4f);
    }

    private void LateUpdate()
    {
        sprRndShadow.sprite = sprRndCaster.sprite;

    }
}
