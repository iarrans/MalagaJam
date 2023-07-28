using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class New : MonoBehaviour
{
    [Header("News List")]
    [SerializeField]
    List<NewSO> newsList;

    [Header("Current New")]
    [SerializeField]
    NewSO currentNew;

    [Header("New In Progress")]
    [SerializeField]
    string title;
    [SerializeField]
    string subTitle;
    [SerializeField]
    Image image;

    int currentNewId;

    void Update()
    {
        
    }

    public void CheckNew()
    {
        //TODO: pensar si al acertar algunas partes de la noticia puede llegar a dar visitas igualmente
        //o si sol hay dos sutiaciones posibles, fallo o acierto
        if (currentNew.title == title && currentNew.subTitle == subTitle && currentNew.image.name == image.name)
        {
            CorrectNew();
        }
        else
        {
            IncorrectNew();
        }
    }

    void CorrectNew()
    {
        //Aumentar visitas

        //Perder cordura

        //Aumentar Id de noticia actual
        currentNewId = currentNew.id;
        currentNewId++;
        currentNew = newsList[currentNewId];
    }

    void IncorrectNew()
    {
        //Perder visitas
        //Ganar cordura     
    }

    void GetNewInProgress()
    {

    }
}
