
using UnityEngine;

namespace Zoo {

    public class Hippo : Animal, IHerbivore {

        public override void SayHello() {
            textBalloon.ShowMessage("splash");
        }

        public void EatLeaves() {
            textBalloon.ShowMessage("munch munch lovely");
        }

    }
    
}