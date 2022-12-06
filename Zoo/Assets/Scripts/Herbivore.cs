using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Herbivore : Animal
{
    public void Start()
    {
        // Set the type of animal
        type = "Herbivore";
    }

    // Eat leaves and say text in the textBalloon
    public void EatLeaves()
    {
        Balloon.SetActive(true);
        text.text = "munch munch lovely";
    }
}