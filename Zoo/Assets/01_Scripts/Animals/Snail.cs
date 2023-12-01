
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo {

    public class Snail : Animal, ICarnivore, IHerbivore, ITrickable {

        public override void SayHello() {
            textBalloon.ShowMessage("*Angry snail noises*");
        }

        public void EatLeaves() {
            textBalloon.ShowMessage("crunch crunch crunch");
        }

        public void EatMeat() {
            textBalloon.ShowMessage("grrrrr");
        }

        public void PerformTrick() {
            StartCoroutine(DoTrick());
        }

        public IEnumerator DoTrick() {
            for (int i = 0; i < 360; i++) {
                transform.localRotation = Quaternion.Euler(i, 0, 0);
                yield return new WaitForEndOfFrame();
            }
        }

    }

}