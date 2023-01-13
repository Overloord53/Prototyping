using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
   [SerializeField] private PlayerHealth health;
   [SerializeField] private Image totalhealthBar;
   [SerializeField] private Image currenthealthBar;


   private void Start()
   {
      totalhealthBar.fillAmount = health.currenthealth / 3;
   }

   private void Update()
   {
      currenthealthBar.fillAmount = health.currenthealth / 3;
   }
}
