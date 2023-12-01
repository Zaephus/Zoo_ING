
using UnityEngine;

namespace Zoo {

    class Zebra : Animal, IHerbivore {

        public override void SayHello() {
            textBalloon.ShowMessage("zebra zebra");
        }

        public void EatLeaves() {
            textBalloon.ShowMessage("munch munch zank yee bra");
        }

    }

}