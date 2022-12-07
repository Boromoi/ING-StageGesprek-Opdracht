using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Pig : Omnivore
    {
        public override void Start()
        {
            // Set canDoTrick before base.Start(), because the ordering is otherwise wrong
            canDoTrick = true;

            base.Start();
        }

        public override void SayHello()
        {
            base.SayHello();

            text.text = "oink oink";
        }

        public override void EatLeaves()
        {
            base.EatLeaves();

            text.text = "munch munch oink";
        }

        public override void EatMeat()
        {
            base.EatMeat();

            text.text = "nomnomnom oink thx";
        }
    }
}