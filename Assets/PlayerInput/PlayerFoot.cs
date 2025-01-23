using System;
using Unity.Netcode;
using Unity.VisualScripting;
using UnityEngine;

namespace Players
{
    public class PlayerFoot : NetworkBehaviour
    {
        public Player player;

        private void OnTriggerEnter2D(Collider2D other)
        {

            if (other.CompareTag("ground")&&IsOwner)
            {
                player._isJumping = false;
            }

            //player.ani.SetInteger("behave", 0);
        }
        
        private void OnTriggerExit2D(Collider2D other)
        {

            if (other.CompareTag("ground")&&IsOwner)
            {
                player._isJumping = true;
            }

        }

    }
}
