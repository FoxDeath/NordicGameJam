using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScreen : MonoBehaviour
{
    Button readyButton;
    void Start()
    {
        MenuManager manager = FindObjectOfType<MenuManager>();
        readyButton = GameObject.Find("ReadyButton").GetComponent<Button>();
        readyButton.onClick.AddListener(manager.Ready);
    }
}
