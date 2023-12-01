
using System.Collections;
using UnityEngine;

namespace Zoo {

    class Tiger : Animal, ICarnivore, ITrickable {

        public override void SayHello() {
            textBalloon.ShowMessage("rraaarww");
        }

        public void EatMeat() {
            textBalloon.ShowMessage("nomnomnom thx wubalubadubdub");
        }

        public void PerformTrick() {
            StartCoroutine(DoTrick());
        }

        public IEnumerator DoTrick() {
            for (int i = 0; i < 360; i++)
            {
                transform.localRotation = Quaternion.Euler(i, 0, 0);
                yield return new WaitForEndOfFrame();
            }
        }

    }

}