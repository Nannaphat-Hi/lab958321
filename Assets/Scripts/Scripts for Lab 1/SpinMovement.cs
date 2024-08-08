using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Nannaphat.GameDev3.Chapter1
{
    public class SpinMovement : MonoBehaviour
    {
        [SerializeField]
        private float _angularSpeed = 5.0f;

        [SerializeField]
        private Vector3 _axisOfRotation = new Vector3(1.0f, 0, 0);

        private Transform _objTransformComponent;

        void Start()
        {
            _objTransformComponent = this.gameObject.GetComponent<Transform>();
        }

        void Update()
        {
            _objTransformComponent.Rotate(_axisOfRotation, _angularSpeed);
        }
    }
}

