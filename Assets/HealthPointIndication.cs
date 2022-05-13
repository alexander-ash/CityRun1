using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// To organize health bar
/// </summary>
public class HealthPointIndication : MonoBehaviour
{
   public Slider healthSlider;

    public void SetStartHeath(int healthpoints)
    {
        healthSlider.maxValue = healthpoints;
        healthSlider.value = healthpoints;
    }
    public void SetHeath(int healthpoints)
    {
        healthSlider.value = healthpoints;
    }

}
    
