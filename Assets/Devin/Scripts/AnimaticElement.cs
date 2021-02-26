using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AnimaticElement : MonoBehaviour, IPointerClickHandler
{
    public string[] myText;
    public Animator myAnim;
    public AnimaticHolder myHolder;
    private int index;

    private void Awake()
    {
        myHolder.myManager.SetText(myText[0]);
        index = 0;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if(myText.Length > index + 1)
        {
            index++;

        }
    }
}
