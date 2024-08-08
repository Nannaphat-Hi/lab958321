using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nannaphat.GameDev3.Chapter2
{
    public class ControlObjectMovementOnXZPlaneUsingTFGH : StepMovement
    {

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                MoveLeft();
            }
            else if (Input.GetKeyDown(KeyCode.H))
            {
                MoveRight();
            }
            else if (Input.GetKeyDown(KeyCode.T))
            {
                MoveForward();
            }
            else if (Input.GetKeyDown(KeyCode.G))
            {
                MoveBackward();
            }

            //Reverse the movement when release a key
            if (Input.GetKeyUp(KeyCode.F))
            {
                MoveRight();
            }
            else if (Input.GetKeyUp(KeyCode.H))
            {
                MoveLeft();
            }
            else if (Input.GetKeyUp(KeyCode.T))
            {
                MoveBackward();
            }
            else if (Input.GetKeyUp(KeyCode.G))
            {
                MoveForward();
            }
        }
    }
}