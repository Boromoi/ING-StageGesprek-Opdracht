using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Tiger : Carnivore
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

            text.text = "rraaarww";
        }

        public override void EatMeat()
        {
            base.EatMeat();

            text.text = "nomnomnom thx wubalubadubdub";
        }
    }
}