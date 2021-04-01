using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scanner : Interactable
{
    public GameObject myOverlay;
    public Text popupText;
    public List<string> myLines;
    public GameObject id;
    private int index = 0;
    public GameObject door;
    private bool active = false;

    public override void MyEvent()
    {
        active = true;
        myOverlay.SetActive(true);
        if (myLines.Count > 0)
        {
            popupText.text = myLines[0];
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && active)
        {
            if (index == 0)
            {
                id.SetActive(true);
            }
            //move to next text, if possible
            if (myLines.Count > index + 1)
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

    public void EndPopup()
    {
        myOverlay.SetActive(false);
        door.SetActive(true);
        gameObject.SetActive(false);
    }
}
