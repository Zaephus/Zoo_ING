
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

        private Coroutine currentCoroutine;

        public void ShowMessage(string _message) {
            if(currentCoroutine != null) {
                StopCoroutine(currentCoroutine);
            }
            text.text = _message;
            currentCoroutine = StartCoroutine(ShowBalloon());
        }

        private IEnumerator ShowBalloon() {
            balloon.SetActive(true);
            yield return new WaitForSeconds(timeActive);
            balloon.SetActive(false);
        }

    }
    
}