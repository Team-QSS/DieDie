using UnityEngine;
using UnityEngine.UI;

public class SkillIcon : MonoBehaviour
{
    public Skill skill;
    public Image icon;
    public SkillTypes skillTypes;
    private void Start()
    {
        icon.sprite = skill.icon;
    }
    public void OnClick()
    {
        if (SkillSelectManager.instance.currentPType == PlayerType.Player1)
        {
            Player1Infomations.instance.ChangeSkill(skillTypes, skill);
        }
        else
        {
            Player2Infomations.instance.ChangeSkill(skillTypes,skill);
        }
    }
}
