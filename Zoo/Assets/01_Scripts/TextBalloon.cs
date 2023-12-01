
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo {

    public class TextBalloon : MonoBehaviour {

        [SerializeField]
        private float timeActive;

        [SerializeField]
        private GameObject balloon;
        [SerializeField]
        private Text text;

        public void ShowMessage(string _message) {
            text.text = _message;
            StartCoroutine(ShowBalloon());
        }

        private IEnumerator ShowBalloon() {
            balloon.SetActive(true);
            yield return new WaitForSeconds(timeActive);
            balloon.SetActive(false);
        }

    }
    
}