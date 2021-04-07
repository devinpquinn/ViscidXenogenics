using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Journal : Popup
{

    public override void EndPopup()
    {
        myManager.nextScene = "Animatic_2";
        myManager.SceneTransition();
    }
}
