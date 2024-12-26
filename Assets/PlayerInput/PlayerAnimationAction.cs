using Players;
using UnityEngine;

public class PlayerAnimationAction : MonoBehaviour
{
    public Player player;
    public void EndAttack()
    {
        player.EndAttack();
    }
}

