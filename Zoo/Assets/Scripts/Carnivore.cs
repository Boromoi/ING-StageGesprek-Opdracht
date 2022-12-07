using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Carnivore : Animal, ICarnivore
{
    public Button meatButton;
    public AudioSource audioSourceMeat;

    public override void Start()
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
    public virtual void EatMeat()
    {
        // Play a soundeffect for eating meat
        audioSourceMeat.Play();

        Balloon.SetActive(true);
    }
}