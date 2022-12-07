using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Lion : Carnivore
    {
        public override void SayHello()
        {
            base.SayHello();

            text.text = "roooaoaaaaar";
        }

        public override void EatMeat()
        {
            base.EatMeat();

            text.text = "nomnomnom thx mate";
        }
    }
}
