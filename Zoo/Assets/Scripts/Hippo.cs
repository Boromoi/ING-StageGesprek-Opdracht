using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


class Hippo : Herbivore
{
    [SerializeField]
    private GameObject Balloon;
    [SerializeField]
    public Text text;

    public override void SayHello()
    {
        Balloon.SetActive(true);
        text.text = "splash";
    }

    public override void EatLeaves()
    {

        //this.transform.GetChild(0).gameObject.SetActive(true);
        //Debug.Log(this.transform.GetChild(0).gameObject.ToString());

        //bloon = this.GetComponentInChildren<Active>;
        //bloon = transform.GetChild(0).gameObject;

        //bloon.SetActive(true);

        //Balloon.SetActive(true);

        //gameObject.SetActive(true);

        //gameObject.transform.GetChild(0).gameObject.SetActive(true);



        Debug.Log("Hippo eatleaves werkt");
        Balloon.SetActive(true);
        text.text = "munch munch lovely"; // munch munch lovely
    }
}