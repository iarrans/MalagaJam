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
        }           
    }

}
