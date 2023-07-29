using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolls : MonoBehaviour
{
    public New newManager;
    //listas a mostrar
    public List<NewSO> newsList;
    public List<string> titles;
    public List<string> subtitles;
    public List<Sprite> images;
     
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

        titles = newManager.titles;

        foreach (string title in titles){

            //instanciaci�n bot�n
            GameObject button = Instantiate(titleButtonPrefab, titleButtonPrefab.transform.parent) as GameObject;
            button.tag = "Delete";
            button.SetActive(true);
            titlesButtons.Add(button);

            //personalizaci�n bot�n
            button.GetComponent<TitleButton>().buttonText.text = title;

            //para la posici�n del bot�n. Relativizamos a bot�n padre y desplazamos hacia abajo
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

        subtitles = newManager.subtitles;

        foreach (string subtitle in subtitles)
        {

            //instanciaci�n bot�n
            GameObject button = Instantiate(subtitleButtonPrefab, subtitleButtonPrefab.transform.parent) as GameObject;
            button.tag = "Delete";
            button.SetActive(true);
            subtitlesButtons.Add(button);

            //personalizaci�n bot�n
            button.GetComponent<SubtitleButton>().buttonText.text = subtitle;

            //para la posici�n del bot�n. Relativizamos a bot�n padre y desplazamos hacia abajo
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

        images = newManager.images;

        foreach (Sprite neew in images)
        {

            //instanciaci�n bot�n
            GameObject button = Instantiate(imageButtonPrefab, imageButtonPrefab.transform.parent) as GameObject;
            button.tag = "Delete";
            button.SetActive(true);
            titlesButtons.Add(button);

            //personalizaci�n bot�n
            button.GetComponent<ImageButton>().buttonSprite.sprite = neew;

            //para la posici�n del bot�n. Relativizamos a bot�n padre y desplazamos hacia abajo
            button.GetComponent<RectTransform>().anchoredPosition = new Vector2(button.GetComponent<RectTransform>().anchoredPosition.x,
                                                                     button.GetComponent<RectTransform>().anchoredPosition.y -
                                                                     button.GetComponent<RectTransform>().sizeDelta.y * (distanciaY)
                                                                     - 10 * distanciaY);

            imageButtonPrefab.transform.parent.GetComponent<RectTransform>().sizeDelta = new Vector2(imageButtonPrefab.transform.parent.GetComponent<RectTransform>().sizeDelta.x,
                                                                                                  button.GetComponent<RectTransform>().sizeDelta.y * (distanciaY + 1)
                                                                                                  + 10 * (distanciaY + 1) + 20);
            distanciaY = distanciaY + 1;

        }

    }

    public void DeletePreviousButtons()
    {
        //borramos los botones que ya exist�an (si es actualizar la lista)

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
