using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndIntro : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(EndAnimationIn());
        SceneManager.LoadScene("MainCanvas");
    }

    IEnumerator EndAnimationIn()
    {
        yield return new WaitForSeconds(24.5f);
    }
}
