using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// To reflect the number of laps passed
/// </summary>
public class LapIndicator : MonoBehaviour 

{
    public Text text;

    public void SetLapIndication(int lapNumber)
    {
        text.text = ($"{lapNumber}");
    }
}
