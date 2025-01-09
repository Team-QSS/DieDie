using UnityEngine;
public class Player2Infomations :MonoBehaviour
{
    public static Player2Infomations instance;
    [Header("플레이어 스킬")]
    [Header("플레이어 매인 스킬(플레이어의 e혹은 i)")]
    public Skill playerMainSkill;
    [Header("플레이어 서브 스킬(플레이어의 r혹은 o)")]
    public Skill playerSubSkill;
    [Header("플레이어 궁극기 스킬(플레이어의 f혹은 ㅣ)")]
    public Skill playerUltimateSkill;

    private void Awake()
    {
        instance = this;
    }
    public void ChangeSkill(SkillTypes skillTypes, Skill skill)
    {
        var slotCode = 0;
        switch (skillTypes)
        {
            case SkillTypes.MainSkill:
                playerMainSkill = skill; slotCode = 0; break;
            case SkillTypes.SubSkill:
                playerSubSkill = skill; slotCode = 1; break;
            case SkillTypes.Ultimate:
                playerUltimateSkill = skill; slotCode = 2; break;
        }
        SkillSelectManager.instance.UpdateSkillUI(slotCode);
    }
}
