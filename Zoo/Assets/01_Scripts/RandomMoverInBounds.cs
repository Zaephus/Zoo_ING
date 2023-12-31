﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo {

    public class RandomMoverInBounds : MonoBehaviour {

        [SerializeField]
        private float speed;

        private Vector3 goal;

        private void Start() {
            goal = GameManager.Instance.GetRandomPositionInBounds();
        }

        private void Update() {
            Vector3 direction = goal - transform.localPosition;
            transform.Translate(direction.normalized * speed * Time.deltaTime);
            if (direction.magnitude < 5) {
                goal = GameManager.Instance.GetRandomPositionInBounds();
            }
        }

    }
    
}