using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public GameObject fadeout;
    public GameObject infoScreen;
    public GameObject creditsScreen;

    private void Awake()
    {
        fadeout.SetActive(true);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            infoScreen.SetActive(false);
            creditsScreen.SetActive(false);
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
