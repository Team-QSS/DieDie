using TMPro;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
public class SkillSlot
{
    public Image image;
    public TextMeshProUGUI name;
    public TextMeshProUGUI description;
    public GameObject descriptionModel;
}
public class SkillSelectManager : MonoBehaviour
{
    public static SkillSelectManager instance;
    public PlayerType currentPType;
    public SkillSlot[] skillSlots;
    private void Awake()
    {
        instance = this;
    }
    public void UpdateSkillUI(int slotCode)
    {
        if (currentPType == PlayerType.Player1)
        {
            switch (slotCode)
            {
                case 0:
                    skillSlots[slotCode].description.text = Player1Infomations.instance.playerMainSkill.description;
                    skillSlots[slotCode].image.sprite = Player1Infomations.instance.playerMainSkill.icon;
                    skillSlots[slotCode].name.text = Player1Infomations.instance.playerMainSkill.skillName;
                    skillSlots[slotCode].descriptionModel.SetActive(true);
                    break;
                case 1:
                    skillSlots[slotCode].description.text = Player1Infomations.instance.playerSubSkill.description;
                    skillSlots[slotCode].image.sprite = Player1Infomations.instance.playerSubSkill.icon;
                    skillSlots[slotCode].name.text = Player1Infomations.instance.playerSubSkill.skillName;
                    skillSlots[slotCode].descriptionModel.SetActive(true);

                    break;
                case 2:
                    skillSlots[slotCode].description.text = Player1Infomations.instance.playerUltimateSkill.description;
                    skillSlots[slotCode].image.sprite = Player1Infomations.instance.playerUltimateSkill.icon;
                    skillSlots[slotCode].name.text = Player1Infomations.instance.playerUltimateSkill.skillName;
                    skillSlots[slotCode].descriptionModel.SetActive(true);
                    break;
            }


        }
        else
        {
            switch (slotCode)
            {
                case 0:
                    skillSlots[slotCode].description.text = Player2Infomations.instance.playerMainSkill.description;
                    skillSlots[slotCode].image.sprite = Player2Infomations.instance.playerMainSkill.icon;
                    skillSlots[slotCode].name.text = Player2Infomations.instance.playerMainSkill.skillName;
                    skillSlots[slotCode].descriptionModel.SetActive(true);
                    break;
                case 1:
                    skillSlots[slotCode].description.text = Player2Infomations.instance.playerSubSkill.description;
                    skillSlots[slotCode].image.sprite = Player2Infomations.instance.playerSubSkill.icon;
                    skillSlots[slotCode].name.text = Player2Infomations.instance.playerSubSkill.skillName;
                    skillSlots[slotCode].descriptionModel.SetActive(true);
                    break;
                case 2:
                    skillSlots[slotCode].description.text = Player2Infomations.instance.playerUltimateSkill.description;
                    skillSlots[slotCode].image.sprite = Player2Infomations.instance.playerUltimateSkill.icon;
                    skillSlots[slotCode].name.text = Player2Infomations.instance.playerUltimateSkill.skillName;
                    skillSlots[slotCode].descriptionModel.SetActive(true);
                    break;
            }
        }
    }
}
