using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Carnivore : Animal
{
    public override void Start()
    {
        // Set the type of animal
        type = "Carnivore";
    }

    // Eat meat and say text in the textBalloon
    public virtual void EatMeat()
    {
        //Balloon.SetActive(true);
        //text.text = "Carnivore eats?";
    }
}