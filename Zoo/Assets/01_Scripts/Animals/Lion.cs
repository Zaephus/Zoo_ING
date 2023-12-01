
using UnityEngine;

namespace Zoo {

    class Lion : Animal, ICarnivore {

        public override void SayHello() {
            textBalloon.ShowMessage("roooaoaaaaar");
        }

        public void EatMeat() {
            textBalloon.ShowMessage("nomnomnom thx mate");
        }

    }

}