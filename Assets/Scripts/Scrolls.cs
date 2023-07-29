using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolls : MonoBehaviour
{
    public New newManager;
    public List<NewSO> newsList;
    public List<GameObject> titlesButtons;
    public List<GameObject> subtitlesButtons;
    public List<GameObject> imagesButtons;

    public GameObject titleButtonPrefab;
    public GameObject subtitleButtonPrefab;
    public GameObject imageButtonPrefab;

    public void Start()
    {
        newsList = newManager.newsList;
    }

    public void PopulateTitlesScroll()
    {
        DeletePreviousButtons();

        int distanciaY = 0;

        foreach (NewSO neew in newsList){

            //instanciación botón
            GameObject button = Instantiate(titleButtonPrefab, titleButtonPrefab.transform.parent) as GameObject;
            button.tag = "Delete";
            button.SetActive(true);
            titlesButtons.Add(button);

            //personalización botón
            button.GetComponent<TitleButton>().buttonText.text = neew.title;

            //para la posición del botón. Relativizamos a botón padre y desplazamos hacia abajo
            button.GetComponent<RectTransform>().anchoredPosition = new Vector2(button.GetComponent<RectTransform>().anchoredPosition.x,
                                                                                button.GetComponent<RectTransform>().anchoredPosition.y -
                                                                                button.GetComponent<RectTransform>().sizeDelta.y * (distanciaY)
                                                                                - 10 * distanciaY);

            titleButtonPrefab.transform.parent.GetComponent<RectTransform>().sizeDelta = new Vector2(titleButtonPrefab.transform.parent.GetComponent<RectTransform>().sizeDelta.x,
                                                                                                  button.GetComponent<RectTransform>().sizeDelta.y * (distanciaY + 1)
                                                                                                  + 10 * (distanciaY + 1) + 20);
            distanciaY = distanciaY + 1;

        }
    }

    public void PopulateSubtitlesScroll()
    {
        DeletePreviousButtons();

        int distanciaY = 0;

        foreach (NewSO neew in newsList)
        {

            //instanciación botón
            GameObject button = Instantiate(subtitleButtonPrefab, subtitleButtonPrefab.transform.parent) as GameObject;
            button.tag = "Delete";
            button.SetActive(true);
            titlesButtons.Add(button);

            //personalización botón
            button.GetComponent<SubtitleButton>().buttonText.text = neew.title;

            //para la posición del botón. Relativizamos a botón padre y desplazamos hacia abajo
            button.GetComponent<RectTransform>().anchoredPosition = new Vector2(button.GetComponent<RectTransform>().anchoredPosition.x,
                                                                                button.GetComponent<RectTransform>().anchoredPosition.y -
                                                                                button.GetComponent<RectTransform>().sizeDelta.y * (distanciaY)
                                                                                - 10 * distanciaY);

            subtitleButtonPrefab.transform.parent.GetComponent<RectTransform>().sizeDelta = new Vector2(subtitleButtonPrefab.transform.parent.GetComponent<RectTransform>().sizeDelta.x,
                                                                                                  button.GetComponent<RectTransform>().sizeDelta.y * (distanciaY + 1)
                                                                                                  + 10 * (distanciaY + 1) + 20);
            distanciaY = distanciaY + 1;

        }

    }

    public void PopulateImagesScroll()
    {
        DeletePreviousButtons();

        int distanciaY = 0;

        foreach (NewSO neew in newsList)
        {

            //instanciación botón
            GameObject button = Instantiate(subtitleButtonPrefab, subtitleButtonPrefab.transform.parent) as GameObject;
            button.tag = "Delete";
            button.SetActive(true);
            titlesButtons.Add(button);

            //personalización botón
            button.GetComponent<ImageButton>().buttonSprite = neew.image;

            //para la posición del botón. Relativizamos a botón padre y desplazamos hacia abajo
            button.GetComponent<RectTransform>().anchoredPosition = new Vector2(button.GetComponent<RectTransform>().anchoredPosition.x,
                                                                                button.GetComponent<RectTransform>().anchoredPosition.y -
                                                                                button.GetComponent<RectTransform>().sizeDelta.y * (distanciaY)
                                                                                - 10 * distanciaY);

            subtitleButtonPrefab.transform.parent.GetComponent<RectTransform>().sizeDelta = new Vector2(subtitleButtonPrefab.transform.parent.GetComponent<RectTransform>().sizeDelta.x,
                                                                                                  button.GetComponent<RectTransform>().sizeDelta.y * (distanciaY + 1)
                                                                                                  + 10 * (distanciaY + 1) + 20);
            distanciaY = distanciaY + 1;

        }

    }

    public void DeletePreviousButtons()
    {
        //borramos los botones que ya existían (si es actualizar la lista)

        GameObject [] existingButtons = GameObject.FindGameObjectsWithTag("Delete");
        titlesButtons.Clear();
        subtitlesButtons.Clear();
        imagesButtons.Clear();
        foreach (GameObject button in existingButtons)
        {
            Destroy(button);
        }
    }
}
