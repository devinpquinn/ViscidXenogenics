using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Interactable : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    public Manager myManager;
    public CursorMode cursorMode = CursorMode.Auto;
    private Vector2 hotSpot = Vector2.zero;

    private void Start()
    {
        myManager = Object.FindObjectOfType<Manager>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (myManager.canInteract)
        {
            MyEvent();
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Cursor.SetCursor(myManager.hoverCursor, hotSpot, cursorMode);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Cursor.SetCursor(myManager.normalCursor, Vector2.zero, cursorMode);
    }

    public virtual void MyEvent()
    {

    }
}
