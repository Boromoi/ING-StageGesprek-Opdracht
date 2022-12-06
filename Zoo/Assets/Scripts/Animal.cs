using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zoo;

public class Animal : MonoBehaviour
{
    public string type;

    public new string name;

    public Button helloButton;

    //public Spawner spawner;

    //[SerializeField]
    //protected GameObject Balloon;
    //[SerializeField]
    //public Text text;

    public virtual void Start()
    {
        helloButton = GameObject.FindGameObjectWithTag("HelloButton").GetComponent<Button>();
        //spawner = new Spawner();
    }

    public virtual void SayHello()
    {
        //Balloon.SetActive(true);
        //text.text = "Animal says hello";
    }
}
