using System;
using Unity.VisualScripting;
using UnityEngine;

namespace Players
{
    public class PlayerFoot : MonoBehaviour
    {
        public Player player;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("ground"))
            {
                player._isJumping = false;
            }

            player.ani.SetInteger("behave",0);
        }
        private void OnTriggerStay2D(Collider2D other)
        {
            player.ani.SetInteger("behave",0);
        }
        
        private void OnTriggerExit2D(Collider2D other)
        {

            if (other.CompareTag("ground"))
            {
                player._isJumping = true;
            }

        }

    }
}
