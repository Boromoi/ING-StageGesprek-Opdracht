using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

class Carnivore : Animal
{
    protected Button meatButton;
    protected AudioSource audioSourceMeat;

    protected override void Start()
    {
        base.Start();

        // Set the type of animal
        type = "Carnivore";

        // Get all the refrences to the objects
        meatButton = GameObject.FindGameObjectWithTag("MeatButton").GetComponent<Button>();
        audioSourceMeat = GameObject.FindGameObjectWithTag("AudioSourceMeat").GetComponent<AudioSource>();

        // Add the onClick event Listeners to the right methods
        meatButton.onClick.AddListener(EatMeat);
    }

    // Eat meat and say text in the textBalloon
    protected virtual void EatMeat()
    {
        // Play a soundeffect for eating meat
        audioSourceMeat.Play();

        Balloon.SetActive(true);
    }
}