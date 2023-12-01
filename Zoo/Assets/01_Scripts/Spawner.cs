
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo {

    public class Spawner : MonoBehaviour {

        [Header("Prefabs")]
        [SerializeField]
        private List<GameObject> animalPrefabs = new();

        [Header("Animals")]
        [SerializeField]
        private List<AnimalSpawnInfo> spawnInfos = new();

        private void Start() {

            foreach(AnimalSpawnInfo info in spawnInfos) {
                GameObject prefab = animalPrefabs.Find(x => x.name.Contains(System.Enum.GetName(typeof(AnimalType), info.type)));
                Vector3 pos = (Vector3)GameManager.Instance.GetRandomPositionInBounds();
                
                Animal animal = Instantiate(prefab, transform).GetComponent<Animal>();
                animal.transform.localPosition = pos;
                animal.animalName = info.name;
                animal.name = info.name;

                GameManager.Instance.animals.Add(animal);
            }

        }

    }

    [System.Serializable]
    public struct AnimalSpawnInfo {
        public AnimalType type;
        public string name;
    }

}