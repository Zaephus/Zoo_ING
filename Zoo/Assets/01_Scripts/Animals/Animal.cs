
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo {

    public abstract class Animal : MonoBehaviour {

        [SerializeField]
        public string animalName;

        [SerializeField]
        protected TextBalloon textBalloon;

        public abstract void SayHello();
        
    }

}