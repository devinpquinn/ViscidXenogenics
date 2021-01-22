﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public bool canInteract = true;
    public GameObject popup;
    public Texture2D normalCursor;
    public Texture2D hoverCursor;
    public Texture2D doorCursor;
    private int inspected = 0;
    public int goal;
    public GameObject moveOn;
    public string nextScene;
    public GameObject fadeScreen;

    private void Start()
    {
        Cursor.SetCursor(normalCursor, Vector2.zero, CursorMode.Auto);
        moveOn.SetActive(false);
        fadeScreen.SetActive(true);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) && popup.activeInHierarchy == true)
        {
            ClosePanel();
        }
    }

    public void AddInspected()
    {
        inspected++;
        if(inspected >= goal)
        {
            moveOn.SetActive(true);
        }
    }

    public void ClosePanel()
    {
        popup.SetActive(false);
        canInteract = true;
    }

    public void SceneTransition()
    {
        StartCoroutine(DoSceneTransition());
    }

    IEnumerator DoSceneTransition()
    {
        fadeScreen.GetComponent<Animator>().Play("fadeOut");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(nextScene);
    }
}
