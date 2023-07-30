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

    bool catEventFlag;
    bool otterEventFlag;
    bool ovniEventFlag;
    bool meteorEventFlag;

    void Start()
    {
        player = GetComponent<Player>();
    }

    void Update()
    {
        
    }

    public void CheckSanityEvent()
    {
        if (player.sanity <= 80  && player.sanity > 70 && catEventFlag == false)
        {
            StartCoroutine(CatEvent());
        }
        else if (player.sanity <= 70 && player.sanity > 60)
        {
            StartCoroutine(DuckEvent());
        }
        else if (player.sanity <= 60 && player.sanity > 40 && otterEventFlag == false)
        {
            StartCoroutine(OtterEvent());
        } 
        else if (player.sanity <= 40 && player.sanity > 20 && ovniEventFlag == false)
        {
            StartCoroutine(OvniEvent());
        }
        else if (player.sanity <= 20 && meteorEventFlag == false)
        {
            StartCoroutine(MeteorEvent());
        }
    }

    IEnumerator CatEvent()
    {
        catEventFlag = true;
        while (catEventFlag)
        {
            catEvent.SetActive(true);
            AudioPlayer.Instance.PlaySFX("KeyboardHit");
            yield return new WaitForSeconds(1);
            catEvent.SetActive(false);
            yield return new WaitForSeconds(Random.Range(5, 10));
        }
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
        otterEventFlag = true;
        while (otterEventFlag)
        {
            otterEvent.SetActive(true);
            AudioPlayer.Instance.PlaySFX("Otter");
            yield return new WaitForSeconds(6.5f);
            otterEvent.SetActive(false);
            yield return new WaitForSeconds(Random.Range(7, 12));
        }
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
        ovniEventFlag = true;
        while(ovniEventFlag)
        {
            ovniEvent.SetActive(true);
            AudioPlayer.Instance.PlaySFX("Ovni");
            yield return new WaitForSeconds(6);
            ovniEvent.SetActive(false);
            yield return new WaitForSeconds(Random.Range(7, 12));
        }
    }

    IEnumerator MeteorEvent()
    {
        meteorEventFlag = true;
        while (meteorEventFlag)
        {
            meteorEvent.SetActive(true);
            AudioPlayer.Instance.PlaySFX("Asteroide");
            yield return new WaitForSeconds(6);
            meteorEvent.SetActive(false);
            yield return new WaitForSeconds(Random.Range(7, 12));
        }
    }
}
