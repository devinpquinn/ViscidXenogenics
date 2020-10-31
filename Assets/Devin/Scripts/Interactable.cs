using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public Manager myManager;
    public CursorMode cursorMode = CursorMode.Auto;
    private Vector2 hotSpot = Vector2.zero;

    private void Start()
    {
        myManager = Object.FindObjectOfType<Manager>();
    }

    void OnMouseEnter()
    {
        Cursor.SetCursor(myManager.hoverCursor, hotSpot, cursorMode);
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(myManager.normalCursor, Vector2.zero, cursorMode);
    }
    

    private void OnMouseDown()
    {
        if(myManager.canInteract)
        {
            MyEvent();
        }
    }

    public virtual void MyEvent()
    {

    }
}
