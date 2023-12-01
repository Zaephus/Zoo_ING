
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo {

    public class Elephant : Animal, IHerbivore {

        public override void SayHello() {
            textBalloon.ShowMessage("pfuuuuuurrrt");
        }

        public void EatLeaves() {
            textBalloon.ShowMessage("hmmm pffft *flaps ears*");
        }

    }

}