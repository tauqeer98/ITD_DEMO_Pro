using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //player will be the target
    public Transform target; 
    //when we have the camera following the player //we don't want to be setting the camera's position to be directly the 
    // exact same as the player's. //what offset will do, it will position the camera outside instead of inside the 
    // player. so we will have certain position so that we hae maintained a certain distance // away from the player
    public Vector3 offset;
    // Update is called once per frame
    void Update() { 
        transform.position = target.position + offset;
    }
}