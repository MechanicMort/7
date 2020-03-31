using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paint : MonoBehaviour
{
    public string colour;
    private int random;
    private void Start()
    {
        random = Random.Range(0, 6);
        if (random == 0)
        {
            colour = "Red";
        }
        else if (random == 1)
        {
            colour = "Orange";
        }
        else if (random == 2)
        {
            colour = "Yellow";
        }
        else if (random == 3)
        {
            colour = "Green";
        }
        else if (random == 4)
        {
            colour = "Purple";
        }

    }
    private void Update()
    {
        
    }
}
