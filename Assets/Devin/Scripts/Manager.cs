using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public bool canInteract = true;
    public GameObject popup;
    public Texture2D normalCursor;
    public Texture2D hoverCursor;

    private void Start()
    {
        Cursor.SetCursor(normalCursor, Vector2.zero, CursorMode.Auto);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) && popup.activeInHierarchy == true)
        {
            ClosePanel();
        }
    }

    public void ClosePanel()
    {
        popup.SetActive(false);
        canInteract = true;
    }
}
