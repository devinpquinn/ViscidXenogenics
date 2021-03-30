using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AnimaticElement : MonoBehaviour
{
    public string[] myText;
    public Animator myAnim;
    public AnimaticHolder myHolder;
    private int index;
    private bool done = false;

    private void Awake()
    {
        myHolder.myManager.SetText(myText[0]);
        index = 0;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) && !done)
        {
            if (myText.Length > index + 1)
            {
                index++;
                myHolder.myManager.SetAnimaticText(myText[index]);
            }
            else
            {
                myAnim.Play("animaticOut");
                done = true;
                myHolder.NextElement();
            }
        }
    }
}
