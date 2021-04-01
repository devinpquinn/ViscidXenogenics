using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimaticHolder : MonoBehaviour
{
    public Manager myManager;
    public Transform elementsParent;
    private GameObject[] myElements;
    public Animator fadeAnim;
    private int index = 0;
    public string nextScene;

    private void Awake()
    {
        FillAnimatic();
    }

    private void Start()
    {
        StartAnimatic();
    }

    public void StartAnimatic()
    {
        myManager.animaticPopup.SetActive(true);
        myManager.canInteract = false;
        myManager.isAnimatic = true;
        myElements[0].SetActive(true);
        fadeAnim.Play("fadeIn");
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
        fadeAnim.Play("fadeOut");
        StartCoroutine(DisableElements());
    }

    IEnumerator DisableElements()
    {
        yield return new WaitForSeconds(1f);
        foreach(GameObject x in myElements)
        {
            x.SetActive(false);
        }

        if(this.gameObject.name == "Animatic 1")
        {
            AnimaticTracker.animatic1played = true;
        }
        else if (this.gameObject.name == "Animatic 2")
        {
            AnimaticTracker.animatic2played = true;
        }
        else if (this.gameObject.name == "Animatic 3")
        {
            AnimaticTracker.animatic3played = true;
        }

        SceneManager.LoadScene(nextScene);
    }
}
