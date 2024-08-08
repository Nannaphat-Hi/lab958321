using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Nannaphat.GameDev3.Chapter1
{
    public class ForwardBackwardAlongXAxisMovement : MonoBehaviour
    {
        public const float MAX_MOVEMENT_DISTANCE = 7.0f;
        private float _displacementCounter = 0;

        [SerializeField]
        private float _xComponentSpeed = 0.02f;

        private Vector3 _currentMovementSpeed = Vector3.zero;

        void Start()
        {
            _currentMovementSpeed.x = _xComponentSpeed;
        }

        void Update()
        {
            transform.position += _currentMovementSpeed;
            _displacementCounter += _currentMovementSpeed.x;

            if (Mathf.Abs(_displacementCounter) > MAX_MOVEMENT_DISTANCE)
            {
                _displacementCounter = 0;
                _currentMovementSpeed *= -1;
            }
        }
    }
}