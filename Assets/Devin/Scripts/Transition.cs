using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Transition : Interactable
{
    public string myScene;

    public override void MyEvent()
    {
        myManager.nextScene = myScene;
        myManager.SceneTransition();
    }

    public override void OnPointerEnter(PointerEventData eventData)
    {
        Cursor.SetCursor(myManager.doorCursor, hotSpot, cursorMode);
    }
}
