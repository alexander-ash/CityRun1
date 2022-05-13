using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Logic of stearing and movement
/// </summary>
public class Driving : MonoBehaviour
{
    [SerializeField] float steerSpeed = 100;
    [SerializeField] float moveSpeed = 20;
    bool notDead = true;

    public void AreYouDead(bool areDead)
    {
        notDead = !(areDead); 
    }

    void Update()
    {
        if (notDead)
        {
            float steeringAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
            float accelerationgAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
            transform.Rotate(0, 0, -steeringAmount);
            transform.Translate(0, accelerationgAmount, 0);
        }
              
    }
}
