using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TitleButton : MonoBehaviour
{
    public TextMeshProUGUI buttonText;

    public NoticiaPrincipal mainNews;


    void Awake()
    {
        mainNews = GameObject.FindWithTag("mainNews").GetComponent<NoticiaPrincipal>();       
    }

    public void ChangeTitle()
    {
        Debug.Log(buttonText.text);
        mainNews.ChangeTitle(buttonText.text);
    }
}
