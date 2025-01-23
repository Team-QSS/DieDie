using Players;
using Unity.Netcode;
using UnityEngine;

public class ProtoPlayer : Player
{
    void Start()
    {
        if (IsOwner)
        {
            SetUpPlayer();
        }

    }

    void Update()
    {
        if (IsOwner||IsHost)
        {
            CheckSkill();
            CheckMovement();
            CheckFloor();
            PlayerBehaveCheck();
        }
    }
}
