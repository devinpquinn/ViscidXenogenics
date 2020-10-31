using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public bool canInteract = true;
    public GameObject popup;

    private void Start()
    {
        popup.transform.Find("Button").GetComponent<Button>().onClick.AddListener(ClosePanel);
    }

    public void ClosePanel()
    {
        popup.SetActive(false);
        canInteract = true;
    }
}
