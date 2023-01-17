using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
public class ScoreScript : MonoBehaviour
{
   public static int scoreValue = 0;
   Text score;

   private void Start()
   {
      score = GetComponent<Text> ();
   }


   private void Update()
   {
      
      score.text = "Points: " + scoreValue;
   }
}
