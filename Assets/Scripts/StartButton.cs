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
        manager.sceneAfterScenario = Loader.Scene.CrossRoad;
        manager.sceneToLoad = Loader.Scene.ScenarioPrint;
        button.onClick.AddListener(manager.StartGame);
    }
}
