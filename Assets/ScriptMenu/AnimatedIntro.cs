using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimatedIntro : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EmpezarJuego());
    }

    IEnumerator EmpezarJuego()
    {
        yield return new WaitForSeconds(22f);
        SceneManager.LoadScene("MainCanvas");
    }
}
