using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

class Omnivore : Animal
{
    protected Button leavesButton;
    protected Button meatButton;

    protected override void Start()
    {
        base.Start();

        // Set the type of animal
        type = "Omnivore";

        leavesButton = GameObject.FindGameObjectWithTag("LeavesButton").GetComponent<Button>();
        meatButton = GameObject.FindGameObjectWithTag("MeatButton").GetComponent<Button>();

        // Add the onClick event Listeners to the right methods
        leavesButton.onClick.AddListener(EatLeaves);
        meatButton.onClick.AddListener(EatMeat);
    }

    // Eat leaves and say text in the textBalloon
    protected virtual void EatLeaves()
    {
        Balloon.SetActive(true);
    }

    // Eat meat and say text in the textBalloon
    protected virtual void EatMeat()
    {
        Balloon.SetActive(true);
    }
}
