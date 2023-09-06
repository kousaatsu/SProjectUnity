using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerSystem
{
    [RequireComponent(typeof(Rigidbody))]
    public class Player : MonoBehaviour
    {
        [field: SerializeField] private float MovementSpeed { get;  }
        [SerializeField] private float rotationSpeed;
        [SerializeField] private float jumpForce;
        [field: SerializeField] public Rigidbody Rb { get; private set; }

        private void Awake()
        {
            Rb = GetComponent<Rigidbody>();
        }
    }
}