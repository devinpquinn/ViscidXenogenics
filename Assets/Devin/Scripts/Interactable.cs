using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public Manager myManager;

    private void Start()
    {
        myManager = Object.FindObjectOfType<Manager>();
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
