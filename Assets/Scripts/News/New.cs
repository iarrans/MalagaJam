using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class New : MonoBehaviour
{
    [Header("Player")]
    [SerializeField]
    Player player;
    
    public List<NewSO> newsList;


    [Header("Current New")]
    [SerializeField]
    NewSO currentNew;

    [Header("New In Progress")]
    [SerializeField]
    string title;
    [SerializeField]
    string subTitle;
    [SerializeField]
    Sprite image;

    public NewsGenerator generator;

    void Update()
    {
        GetNewInProgress();
    }

    public void CheckNew()
    {
        //TODO: pensar si al acertar algunas partes de la noticia puede llegar a dar visitas igualmente
        //o si sol hay dos sutiaciones posibles, fallo o acierto
        generator.GenerateNew();

        foreach (NewSO news in generator.allNews)
        {
            if (title == news.title)
            {
                currentNew = news;
                break;
            }
        }

        Debug.Log("Current new " + currentNew.id + " " + currentNew.title + " " + currentNew.subTitle);
        Debug.Log("In progress " + "subtitle=  " + subTitle + " image= " + image.name);
        newsList.Remove(currentNew);

        if (currentNew.subTitle == subTitle && currentNew.image.name == image.name)
        {
            player.IncreaseVisualizations(10);
            player.DecreaseSanity(10);
            Debug.Log("bien");
        }
        else if (currentNew.subTitle == subTitle || currentNew.image.name == image.name)
        {
            player.DecreaseVisualizations(5);
            player.DecreaseSanity(5);
            Debug.Log("medio bien");
        }
        else
        {
            player.DecreaseVisualizations(10);
            player.DecreaseSanity(0);
            Debug.Log("mal");
        }
    }

    void GetNewInProgress()
    {
        NoticiaPrincipal newInProgress = GameObject.FindGameObjectWithTag("mainNews").GetComponent<NoticiaPrincipal>();
        title = newInProgress.title.text;
        subTitle = newInProgress.subtitle.text;
        image = newInProgress.image.sprite;
    }
}
