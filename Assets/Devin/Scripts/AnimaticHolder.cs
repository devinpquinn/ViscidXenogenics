using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimaticHolder : MonoBehaviour
{
    public Manager myManager;
    public Transform elementsParent;
    private GameObject[] myElements;
    public Animator fadeAnim;
    private int index = 0;

    private void Awake()
    {
        FillAnimatic();
    }

    public void StartAnimatic()
    {
        myManager.animaticPopup.SetActive(true);
        myManager.canInteract = false;
        myManager.isAnimatic = true;
        myElements[0].SetActive(true);
        fadeAnim.Play("fadeOut");
    }

    public void FillAnimatic()
    {
        myElements = new GameObject[elementsParent.childCount];
        for(int i = 0; i < elementsParent.childCount; i++)
        {
            GameObject found = elementsParent.GetChild(i).gameObject;
            myElements[i] = found;
            found.GetComponent<AnimaticElement>().myHolder = this;
        }
    }

    public void NextElement()
    {
        index++;
        if (myElements.Length > index)
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
        index = 0;
        myManager.isAnimatic = false;
        myManager.ClosePanel();
        fadeAnim.Play("fadeIn");
        StartCoroutine(DisableElements());
    }

    IEnumerator DisableElements()
    {
        yield return new WaitForSeconds(1f);
        foreach(GameObject x in myElements)
        {
            x.SetActive(false);
        }
    }
}
