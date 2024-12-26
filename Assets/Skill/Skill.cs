using UnityEngine;
using UnityEngine.EventSystems;

public class Skill : MonoBehaviour
  , IPointerClickHandler
  , IDragHandler
  , IPointerEnterHandler
  , IPointerExitHandler
{
  public void OnPointerClick(PointerEventData eventData)
  {
    Debug.Log("Click");
    Destroy(this.gameObject);
    Destroy(gameObject);
  }
    
  public void OnDrag(PointerEventData eventData)
  {
    Debug.Log("Drag");
  }
    
  public void OnPointerEnter(PointerEventData eventData)
  {
    Debug.Log("Enter");
  }
    
  public void OnPointerExit(PointerEventData eventData)
  {
    Debug.Log("Exit");
  }
}
