using Players;
using Unity.Netcode;
using UnityEngine;

public class PlayerAnimationAction : NetworkBehaviour
{
    public Player player;
    public void EndAttack()
    {
        if (IsOwner)
        {
            player.EndAttack();
        }

    }
}

