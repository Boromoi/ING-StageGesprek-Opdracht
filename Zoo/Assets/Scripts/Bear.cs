using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo
{
    class Bear : Carnivore
    {
        protected override void Start()
        {
            // Set canDoTrick before base.Start(), because the ordering is otherwise wrong
            canDoTrick = true;

            base.Start();
        }

        protected override void SayHello()
        {
            base.SayHello();

            text.text = "gnawrl";
        }

        protected override void EatMeat()
        {
            base.EatMeat();

            text.text = "nomnomnom honey meat";
        }
    }
}