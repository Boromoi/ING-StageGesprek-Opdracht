using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo
{
    class Sheep : Herbivore
    {
        public override void SayHello()
        {
            base.SayHello();

            text.text = "behe beh";
        }

        public override void EatLeaves()
        {
            base.EatLeaves();

            text.text = "munch munch gnrl";
        }
    }
}