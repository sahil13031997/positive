
//Below Code is responsible for 


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCar : MonoBehaviour
{
    //Speed with which whole platform will rotate
    Vector2 SpeedOfRot;
   

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0)
        {
            //Using delta position to get distance between position of touches when swipe to get the required rotation
            SpeedOfRot = Input.touches[0].deltaPosition;              
            transform.RotateAround(Vector3.up, -SpeedOfRot.x / 90);          
        }
        
    }
}