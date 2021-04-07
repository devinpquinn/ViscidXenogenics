using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Popup : Interactable
{

    public GameObject myOverlay;
    public Text popupText;
    public List<string> myLines;
    private int index = 0;
    public bool disableThis;
    private bool active = false;

    public override void MyEvent()
    {
        active = true;
        myOverlay.SetActive(true);
        myManager.canInteract = false;
        if(myLines.Count > 0)
        {
            popupText.text = myLines[0];
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) && active)
        {
            //move to next text, if possible
            if(myLines.Count > index + 1)
            {
                index++;
                popupText.text = myLines[index];
            }
            else
            {
                EndPopup();
            }
        }
    }

    public virtual void EndPopup()
    {
        myOverlay.SetActive(false);
        myManager.canInteract = true;
        if(disableThis)
        {
            gameObject.SetActive(false);
        }
    }
}
