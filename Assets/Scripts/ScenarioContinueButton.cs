using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScenarioContinueButton : MonoBehaviour
{
    public Loader.Scene sceneToLoad;
    MenuManager manager;

    void Start()
    {
        manager = FindObjectOfType<MenuManager>();

        string sceneName = manager.sceneAfterScenario.ToString();

        switch (sceneName)
        {
            case "CatchFruit":
                string text = "You decide to take the time to prepare something for later. You grab your mixer with one hand and reach for the shelf with the other, aiming for the fruit bowl. Your taste buds are already tingling from the thought of the sweet smoothie you’re about to make… That’s when it happens. Your hand slips and fruits are flying all over the place.";
                manager.text = text;
                StartCoroutine(manager.TypeSentence("s"));
                break;

            case "CrossRoad":
                text = "You leave your home with your head held high, feeling proud of your smoothie you worked so hard for, but just as you do so, it hits you. You realise that the kitchen incident you just had was the least of your problems. You left your car at work the other day, forcing you to fight your way through a concrete jungle to get to work.";
                manager.text = text;
                StartCoroutine(manager.TypeSentence("s"));
                break;

            case "OfficePacMan":
                text = "You step through the door of the office, filled with adrenaline from all the near-death experiences you encountered. You take your place in your cubicle. Few hours go by and you decide to reward yourself with the smoothie you prepared. You start spinning with your chair, scouting for anything remotely interesting, when suddenly you lock eyes with your boss. This cannot end well.";
                manager.text = text;
                StartCoroutine(manager.TypeSentence("s"));
                break;
        }
    }

    public void OnClickBehaviour()
    {
        manager.AfterScenario();
    }
}
