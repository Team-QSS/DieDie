using UnityEngine;

public class PlayerSkillSelectUI : MonoBehaviour
{
    public GameObject selectionPannel;
    public GameObject descPannel;
    public bool isSelecting;
    void Start()//모달 초기화
    {
        selectionPannel.SetActive(false);
        //descPannel.SetActive(false);
        isSelecting = false;
    }
    public void OnHover()//각 스킬 선택 칸에 마우스를 올릴때
    {
        if (!isSelecting)
        {
            descPannel.SetActive (true);
        }
        
    }
    public void OutHover()//각 스킬 선택 칸에 마우스를 뺄때
    {
        descPannel.SetActive (false);
    }
    public void OnClick()//각 스킬 선택 칸에 마우스를 클릭할때
    {
        if (!isSelecting)
        {
            selectionPannel.SetActive(true);
            isSelecting=true;
            descPannel.SetActive(false);
        }
    }
}
