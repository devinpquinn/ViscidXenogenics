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
        popup.transform.Find("Button").GetComponent<Button>().onClick.AddListener(ClosePanel);
        Cursor.SetCursor(normalCursor, Vector2.zero, CursorMode.Auto);
    }

    public void ClosePanel()
    {
        popup.SetActive(false);
        canInteract = true;
    }
}
