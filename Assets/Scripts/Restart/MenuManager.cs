using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    TextMeshProUGUI restartText;
    public string text;

    
    Image brightness;
    bool loading = false;
    bool starting = false;
    public Loader.Scene sceneToLoad;

    public static MenuManager instance;
    private void Awake() 
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    void OnSceneWasLoaded(Scene scene, LoadSceneMode mode) 
    {
        try
        {
            brightness = GameObject.Find("Brightness").GetComponent<Image>();
        }
        catch
        {}

        if(brightness != null)
        {
            Color newColor = Color.black;
            newColor.a = 1;
            brightness.color = newColor;
            starting = true;
        }
    }

    private void Update()
    {
        SceneManager.sceneLoaded += OnSceneWasLoaded;
        Load();
    }

    private void Load()
    {
        if (loading)
        {
            Color newColor = brightness.color;
            if(newColor.CompareRGB(Color.black))
            {
                newColor = Color.white;
                newColor.a = 0;
            }
            newColor.a += 1 * Time.deltaTime;
            brightness.color = newColor;
            if (newColor.a >= 1)
            {
                Loader.Load(sceneToLoad);
                loading = false;
            }
        }

        if(starting)
        {
            Color newColor = brightness.color;
            newColor.a -= 1 * Time.deltaTime;
            brightness.color = newColor;
            if(newColor.a <= 0)
            {
                starting = false;
            }
        }
    }

    public void StartGame()
    {
        Clock.GoingForward = true;
        loading = true;
    }

    public IEnumerator TypeSentence()
    {
        restartText = GameObject.Find("Sentance").GetComponent<TextMeshProUGUI>();

        restartText.text = "";

        foreach(char letter in text.ToCharArray())
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
                Clock.GoingForward = false;
                loading = true;
            break;

            case "CrossRoad":
                sceneToLoad = Loader.Scene.CrossRoad;
                Clock.GoingForward = false;
                loading = true;
            break;

            case "OfficePacMan":
                sceneToLoad = Loader.Scene.OfficePacMan;
                Clock.GoingForward = false;
                loading = true;
            break;

            case "CarLabyrinth":
                sceneToLoad = Loader.Scene.CarLabytinth;
                Clock.GoingForward = false;
                loading = true;
            break;
        }
    }

    public void Continue()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        switch(sceneName)
        {
            case "CatchFruit":
                sceneToLoad = Loader.Scene.CrossRoad;
                Clock.GoingForward = true;
                loading = true;
            break;

            case "CrossRoad":
                sceneToLoad = Loader.Scene.OfficePacMan;
                Clock.GoingForward = true;
                loading = true;
            break;

            case "OfficePacMan":
                sceneToLoad = Loader.Scene.CarLabytinth;
                Clock.GoingForward = true;
                loading = true;
            break;

            case "CarLabyrinth":
                sceneToLoad = Loader.Scene.EndGame;
                Clock.GoingForward = true;
                loading = true;
            break;
        }
    }

    public void GiveUp()
    {
        sceneToLoad = Loader.Scene.MainMenu;
        Clock.GoingForward = false;
        loading = true;
    }
}
