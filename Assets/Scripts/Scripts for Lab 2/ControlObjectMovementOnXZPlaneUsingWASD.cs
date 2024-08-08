using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Nannaphat.GameDev3.Chapter2
{
    public class ControlObjectMovementOnXZPlaneUsingWASD : StepMovement
    {

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                MoveLeft();

            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                MoveRight();
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                MoveForward();
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                MoveBackward();
            }
            
            // Mouse
            
            else if (Input.GetMouseButtonDown(0))
            {
                MoveLeft();
            }
            else if (Input.GetMouseButtonDown(1))
            {
                MoveRight();
            }
        }
    }
}