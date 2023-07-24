using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManu : MonoBehaviour
{
    public GameObject playButton;
    public GameObject settingsButton;
    public GameObject exitButton;

    public AudioSource menuSong;
    public AudioSource clickSound;

    public Animator ajustesSreen;

    public void PlayClick()
    {
        clickSound.Play();
        SceneManager.LoadScene("Game");
    }

    public void SettingsClick()
    {
        clickSound.Play();
        ajustesSreen.SetBool("AjustesActive",true);
    }

    public void ExitAjustes()
    {
        clickSound.Play();
        ajustesSreen.SetBool("AjustesActive",false);
    }

    public void ExitClick()
    {
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
