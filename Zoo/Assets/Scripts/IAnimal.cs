using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public interface IAnimal
{
    string type { get; set; }

    string name { get; set; }

    void SayHello();
}