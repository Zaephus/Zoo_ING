
using System.Collections;
using UnityEngine;

namespace Zoo {

    class Pig : Animal, IHerbivore, ICarnivore, ITrickable {

        public override void SayHello() {
            textBalloon.ShowMessage("oink oink");
        }

        public void EatLeaves() {
            textBalloon.ShowMessage("munch munch oink");
        }

        public void EatMeat() {
            textBalloon.ShowMessage("nomnomnom oink thx");
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