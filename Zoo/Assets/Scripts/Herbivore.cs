using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Herbivore : Animal
{
    public Button leavesButton;

    public override void Start()
    {
        // Set the type of animal
        type = "Herbivore";

        leavesButton = GameObject.FindGameObjectWithTag("LeavesButton").GetComponent<Button>();

        //leavesButton.OnPointerClick(EatLeaves());
        leavesButton.onClick.AddListener(EatLeaves);
    }

    // Eat leaves and say text in the textBalloon
    public virtual void EatLeaves()
    {
        //Balloon.SetActive(true);
        //text.text = "Herbivore eats?";
    }
}