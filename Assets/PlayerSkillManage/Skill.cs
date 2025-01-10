using UnityEngine;

[CreateAssetMenu]
public class Skill :ScriptableObject
{
    public int id;//스킬 아이디
    public string skillName;//스킬 이름
    [TextArea]public string description;//스킬 설명
    public Sprite icon;//스킬 아이콘
    //아마 전투 시작 시 스킬 아이디로 실제 액티브 가능한 스킬을 가져올 예정
}
