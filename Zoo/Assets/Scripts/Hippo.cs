using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Hippo : Herbivore
    {
        public override void SayHello()
        {
            base.SayHello();

            text.text = "splash";
        }

        public override void EatLeaves()
        {
            base.EatLeaves();

            text.text = "munch munch lovely";
        }
    }
}