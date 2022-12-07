using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Carnivore : Animal, ICarnivore
{
    public Button meatButton;

    public override void Start()
    {
        base.Start();

        // Set the type of animal
        type = "Carnivore";

        // Get all the refrences to the objects
        meatButton = GameObject.FindGameObjectWithTag("MeatButton").GetComponent<Button>();

        // Add the onClick event Listeners to the right methods
        meatButton.onClick.AddListener(EatMeat);
    }

    // Eat meat and say text in the textBalloon
    public virtual void EatMeat()
    {
        Balloon.SetActive(true);
    }
}