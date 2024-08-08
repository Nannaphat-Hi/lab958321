using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nannaphat.GameDev3.Chapter2
{
    public class ControlObjectMovementOnXZPlaneUsingArrowKeys : StepMovement
    { 
    // Update is called once per frame
    void Update ()
    { 
        //GetKey
        if (Input.GetKey(KeyCode.LeftArrow)) 
        { 
            MoveLeft();
        }
        else if (Input.GetKey(KeyCode.RightArrow)) 
        { 
            MoveRight(); 
        }
        else if (Input.GetKey(KeyCode.UpArrow)) 
        { 
            MoveForward(); 
        }
        else if (Input.GetKey(KeyCode.DownArrow)) 
        { 
            MoveBackward(); 
        } 
    } 
    } 
}