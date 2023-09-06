using System;
using System.Collections;
using System.Collections.Generic;
using PlayerSystem;
using UnityEngine;

namespace InputSystem
{
    public class InputListener : MonoBehaviour
    {
        [SerializeField] private KeyCode jumpKey;
        [SerializeField] private Player player;
        private PlayerInvoker _playerInvoker;

        private void Awake()
        {
            _playerInvoker = new PlayerInvoker(player);
        }

        private void Update()
        {
            ReadJumpKey();
            ReadOffInputKey();
        }

        private void ReadMove()
        {
            //if ()
                _playerInvoker.Move();
        }
        
        private void ReadJumpKey()
        {
            if (Input.GetKeyDown(jumpKey))
            {
                //
            }
        }

        private void ReadOffInputKey()
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                //
            }
        }
    }
}

