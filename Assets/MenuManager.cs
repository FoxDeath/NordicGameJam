using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    TextMeshProUGUI restartText;
    [SerializeField] string text;

    
    Image brightness;
    bool loading = false;
    [SerializeField] Loader.Scene sceneToLoad;
    private void Awake() 
    {
        try
        {
            brightness = GameObject.Find("Brightness").GetComponent<Image>();
            restartText = GameObject.Find("RestartText").GetComponent<TextMeshProUGUI>();
        }
        catch
        {}
    }


    private void Start() 
    {
        if(restartText != null)
        {
            StartCoroutine(TypeSentence(text));
        }
    }

    private void Update()
    {
        Load(sceneToLoad);
    }

    private void Load(Loader.Scene scene)
    {
        if (loading)
        {
            Color newColor = brightness.color;
            newColor.a += 1 * Time.deltaTime;
            brightness.color = newColor;
            if (newColor.a >= 1)
            {
                Loader.Load(scene);
            }
        }
    }

    public void StartGame()
    {
        loading = true;
    }

    IEnumerator TypeSentence(string sentence)
    {
        restartText.text = "";

        foreach(char letter in sentence.ToCharArray())
        {
            restartText.text += letter;

            if(letter.Equals('.') || letter.Equals('?') || letter.Equals('!'))
            {
                yield return new WaitForSeconds(0.5f);
            }
            else
            {
                yield return new WaitForSeconds(0.03f);

            }
        }
    }

    public void TryAgain()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        switch(sceneName)
        {
            case "CatchFruit":
                sceneToLoad = Loader.Scene.CatchFruit;
            break;

            case "CrossRoad":
                sceneToLoad = Loader.Scene.CrossRoad;
            break;

            case "OfficePacMan":
                sceneToLoad = Loader.Scene.OfficePacMan;
            break;

            case "CarLabyrinth":
                sceneToLoad = Loader.Scene.CarLabytinth;
            break;
        }
        StartGame();
    }

    public void GiveUp()
    {
        sceneToLoad = Loader.Scene.MainMenu;
        StartGame();
    }
}
