using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SubtitleButton : MonoBehaviour
{
    public TextMeshProUGUI buttonText;

    public NoticiaPrincipal mainNews;


    void Awake()
    {
        mainNews = GameObject.FindWithTag("mainNews").GetComponent<NoticiaPrincipal>();
    }

    public void ChangeSubtitle()
    {
        Debug.Log(buttonText.text);
        mainNews.ChangeSubtitle(buttonText.text);
    }
}
