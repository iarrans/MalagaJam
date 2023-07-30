using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
    public float timeOfScreen;
    private float counter;

    void Start()
    {
        counter = timeOfScreen;
    }

    private void Update()
    {
        counter -= Time.deltaTime;
        if (counter <= 0)
        {
            SceneManager.LoadScene("MensajeFinal");
        }
    }

}
