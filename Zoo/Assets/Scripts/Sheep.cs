using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo
{
    class Sheep : Herbivore
    {
        protected override void SayHello()
        {
            base.SayHello();

            text.text = "behe beh";
        }

        protected override void EatLeaves()
        {
            base.EatLeaves();

            text.text = "munch munch gnrl";
        }
    }
}