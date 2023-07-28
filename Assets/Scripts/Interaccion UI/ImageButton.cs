using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ImageButton : MonoBehaviour
{
    public Image buttonSprite;

    public NoticiaPrincipal mainNews;


    void Awake()
    {
        mainNews = GameObject.FindWithTag("mainNews").GetComponent<NoticiaPrincipal>();
    }

    public void ChangeImage()
    {
        mainNews.ChangeImage(buttonSprite.sprite);
    }
}
