using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class CImageButton : MonoBehaviour, 
                            IPointerDownHandler, 
                            IPointerUpHandler, 
                            IPointerClickHandler
{
    [SerializeField] private UnityEvent clickEvent;
    [SerializeField] private RectTransform shadow;
    [SerializeField] private float yOffset;

    private Vector2 Pos
    {
        get => shadow.localPosition;
        set => shadow.localPosition = value;
    }

    private Vector2 StartPos 
    { 
        get; 
        set; 
    }

    private void Awake()
    {
        StartPos = Pos;        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        clickEvent.Invoke();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Pos = new Vector2(Pos.x, Pos.y - yOffset);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Pos = StartPos;
    }
}
