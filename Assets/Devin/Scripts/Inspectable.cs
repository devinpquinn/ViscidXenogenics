using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inspectable : Interactable
{
    public string myText = "";

    public override void MyEvent()
    {
        myManager.popup.transform.Find("Text").GetComponent<Text>().text = myText;
        myManager.popup.SetActive(true);
        myManager.canInteract = false;
    }
}
