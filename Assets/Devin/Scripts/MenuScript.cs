using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public GameObject fadeout;

    private void Awake()
    {
        fadeout.SetActive(true);
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
