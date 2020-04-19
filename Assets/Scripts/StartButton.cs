using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        MenuManager manager = FindObjectOfType<MenuManager>();
        manager.sceneToLoad = Loader.Scene.CrossRoad;
        button.onClick.AddListener(manager.StartGame);
    }
}
