using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public GameObject fadeout;
    public GameObject infoScreen;
    public GameObject creditsScreen;
    public GameObject uconnCreditsScreen;
    public Texture2D myCursor;

    private void Awake()
    {
        fadeout.SetActive(true);
        Cursor.SetCursor(myCursor, Vector2.zero, CursorMode.Auto);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            infoScreen.SetActive(false);
            creditsScreen.SetActive(false);
            uconnCreditsScreen.SetActive(false);
        }
    }

    public void StartGame()
    {
        StartCoroutine(LoadGame());
    }

    IEnumerator LoadGame()
    {
        fadeout.GetComponent<Animator>().Play("fadeOut");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Animatic_Open");
    }
}
