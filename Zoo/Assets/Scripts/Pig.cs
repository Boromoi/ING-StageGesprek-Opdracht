﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Pig : Omnivore
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

            text.text = "oink oink";
        }

        protected override void EatLeaves()
        {
            base.EatLeaves();

            text.text = "munch munch oink";
        }

        protected override void EatMeat()
        {
            base.EatMeat();

            text.text = "nomnomnom oink thx";
        }
    }
}