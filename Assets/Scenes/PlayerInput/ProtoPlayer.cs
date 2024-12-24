using Players;
using UnityEngine;

public class ProtoPlayer : Player
{
    void Start()
    {
        SetUpPlayer();
    }

    void Update()
    {
        CheckSkill();
        CheckMovement();
        CheckFloor();

    }
}
