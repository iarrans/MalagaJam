using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    public void Start()
    {
        GetComponent<Slider>().value = AudioListener.volume;
    }

    public void SliderValue(float value)
    {
        AudioListener.volume = value;
    }
}
