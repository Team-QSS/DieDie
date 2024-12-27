using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace PlayerStatus
{
    public enum PlayerTeam
    {
        TeamA,
        TeamB
    }
    public class PlayerInfo : MonoBehaviour
    {
        [Header("팀")] public PlayerTeam team;
        
        [Header("닉네임")] public string nickName;
        
        [Header("초상화")] public Sprite portrait;
        
        [HideInInspector] public float currentHp;
        [Header("최대 HP")] public float maxHp;
        
        [HideInInspector] public float currentSpeed;
        [Header("시작 속도")]public float initSpeed;
        
        [HideInInspector] public float currentUltGauge;
        [Header("궁극기 게이지")] public float maxUltGauge = 100;
        
        [Header("점프하는 힘")] public float jumpForce;
        [Header("최대 점프 횟수")] public int maxJump;
        public int currentJump;
        
        [SerializeField] private float currentPower = 1;
        [SerializeField] private float currentPowerMultiple = 1;
        public float Power => currentPower * currentPowerMultiple;
        
        
        
        // List<Skill> Skills = new()
        public void Init()
        {
            currentUltGauge = 0f;
            currentSpeed = initSpeed;
            currentHp = maxHp;
        }
    }
}
