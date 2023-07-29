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
    public GameObject losePanel;
    public GameObject winPanel;

    [SerializeField]
    int visualizationsForWin;

    SanityEvents sanityEvents;

    void Start()
    {
        sanityEvents = GetComponent<SanityEvents>();
    }

    public void IncreaseVisualizations(int amount)
    {
        visualizations += amount;
        textoVisualizations.text = visualizations.ToString();
        if (visualizations > visualizationsForWin)
        {
            WinGame();
        }
    }

    public void DecreaseVisualizations(int amount)
    {
        visualizations -= amount;
        textoVisualizations.text = visualizations.ToString();
        if (visualizations < 0)
        {
            LoseGame();
        }
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
        sanityEvents.CheckSanityEvent();
        if (sanity <= 0)
        {
            LoseGame();
        }
    }

    void WinGame()
    {
        //No se si aqui va cinematica o que
        //Por ahora panel de victoria placeholder
        winPanel.SetActive(true);
    }

    void LoseGame()
    {
        losePanel.SetActive(true);
    }
}
