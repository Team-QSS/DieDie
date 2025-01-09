using UnityEngine;

public class SkillSets : MonoBehaviour
{
    public static SkillSets instance;
    public Skill originSkill;
    public Skill[] skill1Sets;
    public Skill[] skill2Sets;
    public Skill[] skill3Sets;

    private void Awake()
    {
        instance = this;
    }
}
