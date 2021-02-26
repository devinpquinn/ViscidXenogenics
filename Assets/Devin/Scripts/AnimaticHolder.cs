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
        myManager.isAnimatic = true;
        myElements[0].SetActive(true);
        fadeAnim.Play("fadeOut");
    }

    public void NextElement()
    {
        index++;
        if (myElements.Length > index + 1)
        {
            myElements[index].SetActive(true);
        }
        else
        {
            EndAnimatic();
        }
    }

    public void EndAnimatic()
    {
        myManager.isAnimatic = false;
        myManager.ClosePanel();
        fadeAnim.Play("fadeIn");
    }
}
