using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalMenssage : MonoBehaviour
{
    public void Start()
    {
        VueltaAlInicio();
    }

    public void VueltaAlInicio()
    {
        StartCoroutine(TimerVolverAlMenu());
    }

    IEnumerator TimerVolverAlMenu()
    {
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene("MainMenu");
    }
}
