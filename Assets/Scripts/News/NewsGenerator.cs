using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewsGenerator : MonoBehaviour
{
    public List<NewSO> allNews;
    public New newsController;
    public Player player;
    public int nextNew;

    private void Start()
    {
        nextNew = 0;
        while (nextNew < 5)
        {
            Debug.Log(nextNew);
            GenerateNew();
            nextNew+=1;
        }
    }

    public void GenerateNew()
    {
        if (nextNew < allNews.Count)
        {
            newsController.newsList.Add(allNews[nextNew]);

            //añadimos atributos de nueva noticia a lista
            newsController.subtitles.Add(allNews[nextNew].subTitle);
            newsController.titles.Add(allNews[nextNew].title);
            foreach (string falsesub in allNews[nextNew].falseSubtitles)
            {
                newsController.subtitles.Add(falsesub);
            }
            newsController.images.Add(allNews[nextNew].image);

            //hacemos listas randomizadas con elementos que ya había
            List<string> newsTitlesRand = ShuffleList(newsController.titles);
            List<string> newsSubtitlesRand = ShuffleList(newsController.subtitles);
            List<Sprite> newsSpritesRand = ShuffleList(newsController.images);

            //sustituimos por lista randomizada
            newsController.images = newsSpritesRand;
            newsController.subtitles = newsSubtitlesRand;
            newsController.titles = newsTitlesRand;
        }           
    }

    private List<E> ShuffleList<E>(List<E> inputList)
    {
        List<E> randomList = new List<E>();

        System.Random r = new System.Random();
        int randomIndex = 0;
        while (inputList.Count > 0)
        {
            randomIndex = r.Next(0, inputList.Count); //Choose a random object in the list
            randomList.Add(inputList[randomIndex]); //add it to the new, random list
            inputList.RemoveAt(randomIndex); //remove to avoid duplicates
        }

        return randomList; //return the new random list
    }

}
