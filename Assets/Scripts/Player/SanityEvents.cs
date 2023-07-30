using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SanityEvents : MonoBehaviour
{
    [Header("Events")]
    [SerializeField]
    GameObject catEvent;
    [SerializeField]
    GameObject[] duckEvent;
    [SerializeField]
    GameObject otterEvent;
    [SerializeField]
    GameObject ovniEvent;
    [SerializeField]
    GameObject meteorEvent;

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
            StartCoroutine(DuckEvent());
        }
        else if (player.sanity <= 60 && player.sanity > 40)
        {
            StartCoroutine(OtterEvent());
        } 
        else if (player.sanity <= 40 && player.sanity > 20)
        {
            StartCoroutine(OvniEvent());
        }
        else if (player.sanity <= 20 && player.sanity > 10)
        {
            StartCoroutine(MeteorEvent());
        }
    }

    IEnumerator CatEvent()
    {
        catEvent.SetActive(true);
        AudioPlayer.Instance.PlaySFX("KeyboardHit");
        yield return new WaitForSeconds(1);
        catEvent.SetActive(false);
    }

    IEnumerator DuckEvent()
    {
        foreach (var item in duckEvent)
        {
            item.SetActive(true);
            AudioPlayer.Instance.PlaySFX("Duck");
            yield return new WaitForSeconds(10);
        }
    }

    IEnumerator OtterEvent()
    {
        otterEvent.SetActive(true);
        AudioPlayer.Instance.PlaySFX("Otter");
        yield return new WaitForSeconds(7);
        otterEvent.SetActive(false);
    }

    //IEnumerator LizardEvent()
    //{
    //    lizardEvent.SetActive(true);
    //    AudioPlayer.Instance.PlaySFX("Lizard");
    //    yield return new WaitForSeconds(2);
    //    lizardEvent.SetActive(false);
    //}

    IEnumerator OvniEvent()
    {
        ovniEvent.SetActive(true);
        AudioPlayer.Instance.PlaySFX("Ovni");
        yield return new WaitForSeconds(2);
        ovniEvent.SetActive(false);
    }

    IEnumerator MeteorEvent()
    {
        meteorEvent.SetActive(true);
        AudioPlayer.Instance.PlaySFX("Asteroide");
        yield return new WaitForSeconds(6);
        meteorEvent.SetActive(false);
    }
}
