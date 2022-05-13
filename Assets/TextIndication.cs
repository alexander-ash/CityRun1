using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// To perform text indication
/// </summary>
public class TextIndication : MonoBehaviour
{
    public Text text;
        
    public void SetTextValue(string reflectedText)
    {
        text.text = (reflectedText);
    }
}
