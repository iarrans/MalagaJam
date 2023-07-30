using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void Jugar()
    {
        StartCoroutine(TimerLoadScene());
    }

    IEnumerator TimerLoadScene()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("AnimatedIntro");
    }

    public void Salir()
    {
        Application.Quit();
    }
}
