using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScreen : MonoBehaviour
{
    Button continueButton;
    Button giveUpButton;
    void Start()
    {
        MenuManager manager = FindObjectOfType<MenuManager>();
        continueButton = GameObject.Find("ContinueButton").GetComponent<Button>();
        continueButton.onClick.AddListener(manager.Continue);
        giveUpButton = GameObject.Find("GiveUpButton").GetComponent<Button>();
        giveUpButton.onClick.AddListener(manager.GiveUp);
    }
}
