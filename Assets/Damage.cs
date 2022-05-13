using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Damage : MonoBehaviour
{
    // Based on number of hits can control difficulty;
    [SerializeField] int numberOfHits = 4;
    
    public bool areNotDead = true;
    byte colorChange = 255;
    Color32 initialPlayerDamageColor = new Color32(255, 255, 255, 255); // basic colour of car
    int healthPoints = 100;
    
    public TextIndication textIndication;
    public HealthPointIndication healthPointIndication;
    public Driving driving;

    SpriteRenderer colourRender;

    void Start()
    {
        colourRender = GetComponent<SpriteRenderer>();
        textIndication.SetTextValue ("");
    }

    void Update ()
    {
       
        if (numberOfHits <= 0)
        {
            Debug.Log("WARNING! Hit number below 0");
        }
        else
        {
            if (healthPoints == 0)
            {
                Debug.Log("Boom");
                colourRender.color = new Color32(0, 0, 0, 255);
                textIndication.SetTextValue ("YOU ARE DEAD");
                areNotDead = false;
                driving.AreYouDead(true);
            }
           
        }
    }

    
    void OnCollisionEnter2D(Collision2D other)
    {
      int oneHitDamage = 100 / numberOfHits;
      healthPoints -= oneHitDamage;  
      colorChange = Convert.ToByte(colorChange - (colorChange / numberOfHits));
      Debug.Log($"Ouch! {healthPoints}% left");
      colourRender.color = new Color32(255, colorChange, colorChange, 255);
      healthPointIndication.SetHeath(healthPoints);
    }
    
   
     void OnTriggerEnter2D(Collider2D other)
     {
        if (other.tag == "Repair")
        {
            healthPoints = 100;
            healthPointIndication.SetHeath(healthPoints);
            Debug.Log("Full Heath! 100%");
            colourRender.color = initialPlayerDamageColor;
            colorChange = 255;
        }
      
     }


}



