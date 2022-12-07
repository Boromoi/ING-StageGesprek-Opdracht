using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

class Herbivore : Animal
{
    protected Button leavesButton;
    protected AudioSource audioSourceLeaves;

    protected override void Start()
    {
        base.Start();

        // Set the type of animal
        type = "Herbivore";

        // Get all the refrences to the objects
        leavesButton = GameObject.FindGameObjectWithTag("LeavesButton").GetComponent<Button>();
        audioSourceLeaves = GameObject.FindGameObjectWithTag("AudioSourceLeaves").GetComponent<AudioSource>();

        // Add the onClick event Listeners to the right methods
        leavesButton.onClick.AddListener(EatLeaves);
    }

    // Eat leaves and say text in the textBalloon
    protected virtual void EatLeaves()
    {
        // Play a soundeffect for eating leaves        
        audioSourceLeaves.Play();

        Balloon.SetActive(true);
    }
}