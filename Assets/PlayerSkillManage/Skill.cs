using UnityEngine;

[CreateAssetMenu]
public class Skill :ScriptableObject
{
    public int id;
    public string skillName;
    [TextArea]public string description;
    public Sprite icon;
}
