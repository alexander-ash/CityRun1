using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// this screept is for camera to follow a car
/// </summary>
public class camerafollow : MonoBehaviour
{
    

    [SerializeField] GameObject thingToFollow;
    [SerializeField] float vectorX = 0;
    [SerializeField] float vectorY = 0;
    [SerializeField] float vectorZ = 0;

    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3 (vectorX, vectorY, vectorZ) ;
    }

}
