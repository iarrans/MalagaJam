using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "ScriptableObjects/NewsSO", order = 1)]
public class NewSO : ScriptableObject
{
    public int id;
    public string title;
    public string subTitle;
    public Sprite image;

    public List<string> falseSubtitles;
    public TipoNoticia tipoNoticia;

}
