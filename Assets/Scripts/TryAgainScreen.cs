using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TryAgainScreen : MonoBehaviour
{
    Button tryAgainButton;
    Button giveUpButton;
    void Start()
    {
        MenuManager manager = FindObjectOfType<MenuManager>();
        tryAgainButton = GameObject.Find("TryAgainButton").GetComponent<Button>();
        tryAgainButton.onClick.AddListener(manager.TryAgain);
        giveUpButton = GameObject.Find("GiveUpButton").GetComponent<Button>();
        giveUpButton.onClick.AddListener(manager.GiveUp);
    }
}
