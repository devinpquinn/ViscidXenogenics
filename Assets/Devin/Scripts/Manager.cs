using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public bool canInteract = true;
    public GameObject popup;
    public GameObject animaticPopup;
    public Texture2D normalCursor;
    public Texture2D hoverCursor;
    public Texture2D doorCursor;
    private int inspected = 0;
    public int goal;
    public GameObject moveOn;
    public GameObject moveOn2;
    public string nextScene;
    public GameObject fadeScreen;
    private Text myText;
    private Text animaticText;
    public bool isAnimatic;

    private void Start()
    {
        Cursor.SetCursor(normalCursor, Vector2.zero, CursorMode.Auto);
        moveOn.SetActive(false);
        moveOn2.SetActive(false);
        fadeScreen.SetActive(true);
        myText = popup.transform.Find("Text").GetComponent<Text>();
        animaticText = animaticPopup.transform.Find("Text").GetComponent<Text>();
        isAnimatic = false;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) && popup.activeInHierarchy == true && isAnimatic == false)
        {
            ClosePanel();
        }
    }

    public void SetText(string toSet)
    {
        myText.text = toSet;
    }

    public void SetAnimaticText(string toSet)
    {
        animaticText.text = toSet;
    }

    public void AddInspected()
    {
        inspected++;
        if(inspected >= goal)
        {
            moveOn.SetActive(true);
            moveOn2.SetActive(true);
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
