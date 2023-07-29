using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewsGenerator : MonoBehaviour
{
    public List<NewSO> allNews;
    public New newsController;
    public Player player;

    private void Start()
    {
        int index = 0;
        while (index < 5)
        {
            GenerateNew();
            index++;
        }
    }

    public void GenerateNew()
    {       
        newsController.newsList.Add(allNews[0]);
        allNews.RemoveAt(0);      
    }

}
