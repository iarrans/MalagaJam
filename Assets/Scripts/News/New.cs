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

    int currentNewId;

    void Update()
    {
        GetNewInProgress();
    }

    public void CheckNew()
    {
        //TODO: pensar si al acertar algunas partes de la noticia puede llegar a dar visitas igualmente
        //o si sol hay dos sutiaciones posibles, fallo o acierto
        generator.GenerateNew();
       
        if (currentNew.title == title && currentNew.subTitle == subTitle && currentNew.image.name == image.name)
        {
            CorrectNew();
        }
        else
        {
            IncorrectNew();
        }
    }

    //TODO: Si va a haber varios grados de fallo o acierto, la cantidad de incremento y decremento debe calcularse
    void CorrectNew()
    {
        player.IncreaseVisualizations(10);
        player.DecreaseSanity(10);

        // Increase current new Id
        currentNewId = currentNew.id;
        currentNewId++;
        currentNew = newsList[currentNewId];
    }

    void IncorrectNew()
    {
        player.DecreaseVisualizations(10);
        player.IncreaseSanity(10);
    }

    void GetNewInProgress()
    {
        NoticiaPrincipal newInProgress = GameObject.FindGameObjectWithTag("mainNews").GetComponent<NoticiaPrincipal>();
        title = newInProgress.title.text;
        subTitle = newInProgress.subtitle.text;
        image = newInProgress.image.sprite;
    }
}
