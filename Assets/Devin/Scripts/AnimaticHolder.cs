using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimaticHolder : MonoBehaviour
{
    public Manager myManager;
    public GameObject[] myElements;
    public Animator fadeAnim;
    private int index = 0;

    public void StartAnimatic()
    {
        myManager.popup.SetActive(true);
        myManager.canInteract = false;
        myElements[0].SetActive(true);
    }

    public void NextElement()
    {

    }

    public void EndAnimatic()
    {

    }
}
