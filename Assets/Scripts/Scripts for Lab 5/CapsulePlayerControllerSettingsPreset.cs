using UnityEngine;
using UnityEngine.InputSystem;

namespace Nannaphat.GameDev3.Chapter5.SOClasses
{
    [CreateAssetMenu(fileName = "CapsulePlayerControllerSettingsPreset",
        menuName = "GameDev3/Chapter5/CapsulePlayerControllerSettingsPreset",
        order = 0)]
    public class CapsulePlayerControllerSettingsPreset : ScriptableObject
    {
        public float RotationSpeed = 180;
        public float DirectionalSpeed = 3;
        public float DirectionalSprintSpeed = 5;

        [Header("Keys Config")] public Key ForwardKey = Key.W;
        public Key BackwardKey = Key.S;
        public Key TurnLeftKey = Key.A;
        public Key TurnRightKey = Key.D;

        public Key SprintKey = Key.LeftShift;
        public Key InteractionKey = Key.E;
    }
}