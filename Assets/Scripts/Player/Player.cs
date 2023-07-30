using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int visualizations = 0;
    public float sanity = 100;
    float maxSanity = 100;
    public TextMeshProUGUI textoCordura;
    public TextMeshProUGUI textoVisualizations;
    public GameObject losePanel;
    public GameObject winPanel;
    public int correctNews;
    public int numberWinningNews;

    public Image medidorCordura;

    SanityEvents sanityEvents;

    void Start()
    {
        sanityEvents = GetComponent<SanityEvents>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            AudioPlayer.Instance.PlaySFX("Click");
        }
    }

    public void IncreaseVisualizations(int amount)
    {
        visualizations += amount;
        textoVisualizations.text = visualizations.ToString();
        if (correctNews > numberWinningNews)
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
        medidorCordura.fillAmount = amount;
    }

    public void DecreaseSanity(int amount)
    {
        sanity -= amount;
        textoCordura.text = sanity.ToString();
        medidorCordura.fillAmount = sanity/maxSanity;
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
