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
    bool canClickButton = true;
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
            if (newColor.a >= 2)
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
                StartMiniGame();
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

        AudioManager audioManager = FindObjectOfType<AudioManager>();

        foreach(char letter in text.ToCharArray())
        {
            restartText.text += letter;

            if(!letter.Equals(' '))
            {
                audioManager.SetPitch("voice", Random.Range(0.8f, 1.2f));
                audioManager.Play("voice");
            }

            if(letter.Equals('.') || letter.Equals('?') || letter.Equals('!'))
            {
                yield return new WaitForSeconds(0.5f);
            }
            else
            {
                yield return new WaitForSeconds(0.1f);
            }
        }
    }

    public void TryAgain()
    {
        if(!canClickButton)
        {
            return;
        }
        
        StartCoroutine(TryAgainBehaviour());
    }

    IEnumerator TryAgainBehaviour()
    {
        canClickButton = false;

        text = "You probably won't make it this time again.";
        yield return StartCoroutine(TypeSentence());

        yield return new WaitForSeconds(2f);

        string sceneName = SceneManager.GetActiveScene().name;
        switch (sceneName)
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

        canClickButton = true;
    }

    public void Continue()
    {
        if(!canClickButton)
        {
            return;
        }
        
        StartCoroutine(ContinueBehaviour());
    }

    IEnumerator ContinueBehaviour()
    {
        canClickButton = false;

        text = "Sure, go on. You will fail eventually.";
        yield return StartCoroutine(TypeSentence());

        yield return new WaitForSeconds(2f);

        string sceneName = SceneManager.GetActiveScene().name;
        switch (sceneName)
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

        canClickButton = true;
    }

    public void GiveUp()
    {
        if(!canClickButton)
        {
            return;
        }
        
        StartCoroutine(GiveUpBehaviour());
    }

    IEnumerator GiveUpBehaviour()
    {
        canClickButton = false;

        text = "That's right, give up.";
        yield return StartCoroutine(TypeSentence());

        yield return new WaitForSeconds(2f);

        sceneToLoad = Loader.Scene.MainMenu;
        Clock.GoingForward = false;
        loading = true;

        canClickButton = true;
    }

    public void StartMiniGame()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        switch (sceneName)
        {
            case "CatchFruit":
                text = "Are you ready for breakfast";
                break;

            case "CrossRoad":
                
                break;

            case "OfficePacMan":
                
                break;

            case "CarLabyrinth":
                
                break;
        }

        StartCoroutine(TypeSentence());
    }

    public void Ready()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        switch (sceneName)
        {
            case "CatchFruit":
                StartCoroutine(FindObjectOfType<FruitSpawner>().SpawnFruit());
                GameObject.Find("StartScreen").SetActive(false);
                GameObject.Find("RecipeParent").transform.GetChild(0).gameObject.SetActive(true);
                break;

            case "CrossRoad":
                
                break;

            case "OfficePacMan":
                
                break;

            case "CarLabyrinth":
                
                break;
        }
    }
}
