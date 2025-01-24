using Players;
using Unity.Netcode;
using UnityEngine;

public class ProtoPlayer : Player
{
    void Start()
    {
            SetUpPlayer();
        

    }

    void Update()
    {
        if (IsOwner)
        {
            CheckSkill();
            CheckMovement();
            CheckFloor();
            PlayerBehaveCheckServerRpc();
        }
    }
}
