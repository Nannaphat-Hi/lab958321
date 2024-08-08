using UnityEngine.InputSystem;

namespace Nannaphat.GameDev3.Chapter2.InputSystem
{
    public class ControlObjectMovementOnXZPlaneUsingArrowKeys : StepMovement
    {
        // Update is called once per frame
        void Update ()
        {
            Keyboard keyboard = Keyboard.current;
            
            //GetKey
            if (keyboard[Key.LeftArrow].isPressed)
            {
                MoveLeft();
            }
            else if (keyboard[Key.RightArrow].isPressed)
            {
                MoveRight();
            }
            else if (keyboard[Key.UpArrow].isPressed)
            {
                MoveForward();
            }
            else if (keyboard[Key.DownArrow].isPressed)
            {
                MoveBackward();
            }
        }
    }
}