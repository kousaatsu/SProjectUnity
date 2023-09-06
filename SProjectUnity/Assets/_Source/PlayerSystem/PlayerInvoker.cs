using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerSystem
{
    public class PlayerInvoker
    {
        private PlayerMovement _playerMovement;
        private Player _player;

        public PlayerInvoker(Player player)
        {
            _player = player;
            _playerMovement = new PlayerMovement();
        }

        public void Move()
        {
            _playerMovement.Move(_player.Rb, _player.MovementSpeed());
        }
    }
}

