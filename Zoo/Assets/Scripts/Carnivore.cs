using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Carnivore : Animal
{
    public void Start()
    {
        // Set the type of animal
        type = "Carnivore";
    }

    // Eat meat and say text in the textBalloon
    public void EatMeat()
    {
        Balloon.SetActive(true);
        text.text = "nomnomnom thx mate";
    }
}
