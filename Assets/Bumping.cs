using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumping : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Boom!");

    }

     void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("WARNIIIIING!");
    }
   
}



