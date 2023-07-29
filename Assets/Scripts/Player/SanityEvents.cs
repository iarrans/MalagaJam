using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SanityEvents : MonoBehaviour
{
    [Header("Events")]
    [SerializeField]
    GameObject catEvent;
    [SerializeField]
    GameObject duckEvent;
    [SerializeField]
    GameObject otterEvent;
    [SerializeField]
    GameObject lizardEvent;

    Player player;

    void Start()
    {
        player = GetComponent<Player>();
    }

    public void CheckSanityEvent()
    {
        if (player.sanity <= 80  && player.sanity > 70)
        {
            StartCoroutine(CatEvent());
        }
        else if (player.sanity <= 70 && player.sanity > 60)
        {
            DuckEvent();
        }
        else if (player.sanity <= 60 && player.sanity > 40)
        {
            StartCoroutine(OtterEvent());
        } 
        else if (player.sanity <= 40 && player.sanity > 20)
        {
            StartCoroutine(LizardEvent());
        }
        else if (player.sanity <= 20 && player.sanity > 10)
        {
            //Meteorito
        }
    }

    IEnumerator CatEvent()
    {
        catEvent.SetActive(true);
        AudioPlayer.Instance.PlaySFX("KeyboardHit");
        yield return new WaitForSeconds(1);
        catEvent.SetActive(false);
    }

    void DuckEvent()
    {
        duckEvent.SetActive(true);
        AudioPlayer.Instance.PlaySFX("Duck");
    }

    IEnumerator OtterEvent()
    {
        otterEvent.SetActive(true);
        AudioPlayer.Instance.PlaySFX("Otter");
        yield return new WaitForSeconds(7);
        otterEvent.SetActive(false);
    }

    IEnumerator LizardEvent()
    {
        lizardEvent.SetActive(true);
        AudioPlayer.Instance.PlaySFX("Lizard");
        yield return new WaitForSeconds(2);
        lizardEvent.SetActive(false);

    }
}
