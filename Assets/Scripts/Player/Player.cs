using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int visualizations = 0;
    public int sanity = 100;

    public void IncreaseVisualizations(int amount)
    {
        visualizations += amount;
    }

    public void DecreaseVisualizations(int amount)
    {
        visualizations -= amount;
    }

    public void IncreaseSanity(int amount)
    {
        sanity += amount;
    }

    public void DecreaseSanity(int amount)
    {
        sanity -= amount;
    }
}
