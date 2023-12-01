
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zoo;

public class GameManager : Singleton<GameManager> {

    public Vector2 minBounds, maxBounds;

    [HideInInspector]
    public List<Animal> animals = new();

    [SerializeField]
    private InputField inputField;

    public void GiveLeaves() {
        Debug.Log("Give leaves to all animals that can eat leaves");
        foreach(Animal animal in animals) {
            animal.GetComponent<IHerbivore>()?.EatLeaves();
        }
    }

    public void GiveMeat() {
        Debug.Log("Give meat to all animals that can eat meat.");
        foreach(Animal animal in animals) {
            animal.GetComponent<ICarnivore>()?.EatMeat();
        }
    }

    public void DoTrick() {
        Debug.Log("All animals that can do a trick do them.");
        foreach(Animal animal in animals) {
            animal.GetComponent<ITrickable>()?.PerformTrick();
        }
    }

    public void SayHello() {
        Animal animal = animals.Find(x => x.animalName == inputField.text);
        if(animal != null) {
            animal.SayHello();
            Debug.Log($"{animal.animalName} makes their sound!");
        }
        else {
            foreach(Animal a in animals) {
                a.SayHello();
            }
            Debug.Log("All animals make their sound!");
        }
    }

    public Vector2 GetRandomPositionInBounds() {
        Vector2 pos = new Vector2(
            transform.position.x + Random.Range(minBounds.x, maxBounds.x),
            transform.position.y + Random.Range(minBounds.y, maxBounds.y)
        );
        return pos;
    }

}