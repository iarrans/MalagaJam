using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int visualizations = 0;
    public int sanity = 100;
    public TextMeshProUGUI textoCordura;
    public TextMeshProUGUI textoVisualizations;


    public void IncreaseVisualizations(int amount)
    {
        visualizations += amount;
        textoVisualizations.text = visualizations.ToString();
    }

    public void DecreaseVisualizations(int amount)
    {
        visualizations -= amount;
        textoVisualizations.text = visualizations.ToString();
    }

    public void IncreaseSanity(int amount)
    {
        sanity += amount;
        textoCordura.text = sanity.ToString();
    }

    public void DecreaseSanity(int amount)
    {
        sanity -= amount;
        textoCordura.text = sanity.ToString();
    }
}
