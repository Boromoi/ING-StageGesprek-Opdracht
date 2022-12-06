using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animal : MonoBehaviour, IAnimal
{
    public virtual string type { get => type; set => type = value; }
    public virtual string name { get => name; set => name = value; }

    [SerializeField]
    protected GameObject Balloon;
    [SerializeField]
    protected Text text;

    public void SayHello()
    {
        Balloon.SetActive(true);
        text.text = "splash";
    }
}
