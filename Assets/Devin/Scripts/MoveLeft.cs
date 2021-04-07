using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public Transform myCam;
    public Manager myManager;
    public float speed;
    private float limit_x = 0;

    private void OnMouseOver()
    {
        if(myManager.canInteract)
        {
            myCam.Translate((-(speed / 100)) * Time.deltaTime, 0, 0);
            if (myCam.position.x < limit_x)
            {
                myCam.position = new Vector3(limit_x, myCam.transform.position.y, myCam.transform.position.z);
            }
        }
    }
}
