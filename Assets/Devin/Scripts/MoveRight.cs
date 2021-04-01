﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    public Transform myCam;
    public float speed;
    public float limit_x;

    private void OnMouseOver()
    {
        myCam.Translate(speed / 100, 0, 0);
        if(myCam.position.x > limit_x)
        {
            myCam.position = new Vector3(limit_x, myCam.transform.position.y, myCam.transform.position.z);
        }
    }
}
