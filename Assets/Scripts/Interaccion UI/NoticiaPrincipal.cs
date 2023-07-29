using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NoticiaPrincipal : MonoBehaviour
{
    public TextMeshProUGUI title;

    public TextMeshProUGUI subtitle;

    public Image image;


    public void ChangeImage(Sprite newImage)
    {
        image.sprite = newImage;
    }

    public void ChangeTitle(string newTitle)
    {
        title.text = newTitle;
    }

    public void ChangeSubtitle(string newSubtitle)
    {
        subtitle.text = newSubtitle;
    }

}
