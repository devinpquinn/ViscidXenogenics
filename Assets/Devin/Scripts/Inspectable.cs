using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inspectable : Interactable
{
    [TextArea(15, 20)]
    public string myText = "";

    public override void MyEvent()
    {
        myManager.SetText(myText);
        myManager.popup.SetActive(true);
        myManager.canInteract = false;
    }
}
