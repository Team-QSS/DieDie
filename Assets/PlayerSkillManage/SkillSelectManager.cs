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
    private void Start()
    {
        if(currentPType == PlayerType.Player1)
        {
            Player1Infomations.instance.InitAllSkill();
            
        }
        else
        {
            Player2Infomations.instance.InitAllSkill();
        }
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
                    break;
                case 1:
                    skillSlots[slotCode].description.text = Player1Infomations.instance.playerSubSkill.description;
                    skillSlots[slotCode].image.sprite = Player1Infomations.instance.playerSubSkill.icon;
                    skillSlots[slotCode].name.text = Player1Infomations.instance.playerSubSkill.skillName;
                    break;
                case 2:
                    skillSlots[slotCode].description.text = Player1Infomations.instance.playerUltimateSkill.description;
                    skillSlots[slotCode].image.sprite = Player1Infomations.instance.playerUltimateSkill.icon;
                    skillSlots[slotCode].name.text = Player1Infomations.instance.playerUltimateSkill.skillName;
                    break;
                case 3:
                    skillSlots[0].description.text = Player1Infomations.instance.playerMainSkill.description;
                    skillSlots[0].image.sprite = Player1Infomations.instance.playerMainSkill.icon;
                    skillSlots[0].name.text = Player1Infomations.instance.playerMainSkill.skillName;
                    skillSlots[0].descriptionModel.SetActive(true);
                    skillSlots[1].description.text = Player1Infomations.instance.playerSubSkill.description;
                    skillSlots[1].image.sprite = Player1Infomations.instance.playerSubSkill.icon;
                    skillSlots[1].name.text = Player1Infomations.instance.playerSubSkill.skillName;
                    skillSlots[1].descriptionModel.SetActive(true);
                    skillSlots[2].description.text = Player1Infomations.instance.playerUltimateSkill.description;
                    skillSlots[2].image.sprite = Player1Infomations.instance.playerUltimateSkill.icon;
                    skillSlots[2].name.text = Player1Infomations.instance.playerUltimateSkill.skillName;
                    skillSlots[2].descriptionModel.SetActive(true);
                    break;
            }
            if (slotCode < 3)
            {
                skillSlots[slotCode].descriptionModel.SetActive(true);
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
                    break;
                case 1:
                    skillSlots[slotCode].description.text = Player2Infomations.instance.playerSubSkill.description;
                    skillSlots[slotCode].image.sprite = Player2Infomations.instance.playerSubSkill.icon;
                    skillSlots[slotCode].name.text = Player2Infomations.instance.playerSubSkill.skillName;
                    break;
                case 2:
                    skillSlots[slotCode].description.text = Player2Infomations.instance.playerUltimateSkill.description;
                    skillSlots[slotCode].image.sprite = Player2Infomations.instance.playerUltimateSkill.icon;
                    skillSlots[slotCode].name.text = Player2Infomations.instance.playerUltimateSkill.skillName;
                    break;
                case 3:
                    skillSlots[0].description.text = Player2Infomations.instance.playerMainSkill.description;
                    skillSlots[0].image.sprite = Player2Infomations.instance.playerMainSkill.icon;
                    skillSlots[0].name.text = Player2Infomations.instance.playerMainSkill.skillName;
                    skillSlots[0].descriptionModel.SetActive(true);
                    skillSlots[1].description.text = Player2Infomations.instance.playerSubSkill.description;
                    skillSlots[1].image.sprite = Player2Infomations.instance.playerSubSkill.icon;
                    skillSlots[1].name.text = Player2Infomations.instance.playerSubSkill.skillName;
                    skillSlots[1].descriptionModel.SetActive(true);
                    skillSlots[2].description.text = Player2Infomations.instance.playerUltimateSkill.description;
                    skillSlots[2].image.sprite = Player2Infomations.instance.playerUltimateSkill.icon;
                    skillSlots[2].name.text = Player2Infomations.instance.playerUltimateSkill.skillName;
                    skillSlots[2].descriptionModel.SetActive(true);
                    break;
            }
            skillSlots[slotCode].descriptionModel.SetActive(true);
        }
    }
}
