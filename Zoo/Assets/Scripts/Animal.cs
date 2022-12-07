using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zoo;

class Animal : MonoBehaviour
{
    protected string type;
    public new string name;

    protected bool canDoTrick = false;

    protected Button helloButton;
    protected Button trickButton;
    protected InputField inputField;    

    protected GameObject Balloon;
    protected Text text;

    protected virtual void Start()
    {
        // Get all the refrences to the objects
        Balloon = gameObject.transform.GetChild(0).gameObject;
        text = Balloon.transform.GetChild(0).GetComponent<Text>();

        helloButton = GameObject.FindGameObjectWithTag("HelloButton").GetComponent<Button>();
        trickButton = GameObject.FindGameObjectWithTag("TrickButton").GetComponent<Button>();
        inputField = GameObject.FindGameObjectWithTag("InputField").GetComponent<InputField>();


        // Subscribe the buttons to the right methods
        helloButton.onClick.AddListener(SayHello);

        if (canDoTrick)
        {
            trickButton.onClick.AddListener(PerformTrick);
        }
    }

    protected virtual void SayHello()
    {
        // Check if the text in the inputField is the same as the animals name or if the field is empty
        if (inputField.text == this.name || inputField.text == "")
        {
            Balloon.SetActive(true);
        }
    }

    protected virtual void PerformTrick()
    {
        StartCoroutine(DoTrick());
    }

    protected virtual IEnumerator DoTrick()
    {
        for (int i = 0; i < 360; i++)
        {
            transform.localRotation = Quaternion.Euler(i, 0, 0);
            yield return new WaitForEndOfFrame();
        }
    }
}