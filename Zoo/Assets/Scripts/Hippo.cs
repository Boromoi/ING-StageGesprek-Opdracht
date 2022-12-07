using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Hippo : Herbivore
    {
        protected override void SayHello()
        {
            base.SayHello();

            text.text = "splash";
        }

        protected override void EatLeaves()
        {
            base.EatLeaves();

            text.text = "munch munch lovely";
        }
    }
}