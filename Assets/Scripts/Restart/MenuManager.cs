using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public static MenuManager instance;

    public Loader.Scene sceneToLoad;
    public Loader.Scene sceneAfterScenario;
    TextMeshProUGUI restartText;
    Image brightness;

    [SerializeField] TMP_FontAsset depressionFont;
    [SerializeField] TMP_FontAsset scenarioFont;

    public bool loading = false;
    bool starting = false;
    bool canClickButton = true;
    bool writingText = false;

    public string text;

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
        if(brightness == null)
        {
            try
        {
            brightness = GameObject.Find("Brightness").GetComponent<Image>();
        }
        catch
        {}
        }

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

    public IEnumerator TypeSentence(string font)
    {
        TurnButtons(false);

        writingText = true;

        restartText = GameObject.Find("Sentance").GetComponent<TextMeshProUGUI>();

        restartText.text = "";

        if (font.Equals("d"))
        {
            restartText.font = depressionFont;
            restartText.fontSize = 70;
        }
        else
        {
            restartText.font = scenarioFont;
            restartText.fontSize = 38;
        }

        AudioManager audioManager = FindObjectOfType<AudioManager>();

        foreach(char letter in text.ToCharArray())
        {
            restartText.text += letter;

            if(!letter.Equals(' ') && font.Equals("d"))
            {
                audioManager.SetPitch("voice", Random.Range(0.8f, 1.2f));
                audioManager.Play("voice");
            }

            if(letter.Equals('.') || letter.Equals('?') || letter.Equals('!'))
            {
                yield return new WaitForSeconds(0.35f);
            }
            else
            {
                if (font.Equals("d"))
                {
                    yield return new WaitForSeconds(0.05f);
                }
                else
                {
                    yield return new WaitForSeconds(0.02f);
                }
            }
        }

        TurnButtons(true);

        writingText = false;
    }

    private void TurnButtons(bool state)
    {
        foreach (GameObject b in GameObject.FindGameObjectsWithTag("Button"))
        {
            b.transform.GetChild(0).gameObject.SetActive(state);
        }
    }

    public void TryAgain()
    {
        if(!canClickButton || writingText)
        {
            return;
        }
        
        StartCoroutine(TryAgainBehaviour());
    }

    IEnumerator TryAgainBehaviour()
    {
        canClickButton = false;

        //text = "You probably won't make it this time again.";
        //yield return StartCoroutine(TypeSentence());

        //TurnButtons(false);

        //yield return new WaitForSeconds(2f);
        yield return null;

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

            case "OfficePacman":
                sceneToLoad = Loader.Scene.OfficePacMan;
                Clock.GoingForward = false;
                loading = true;
                break;
        }

        canClickButton = true;
    }

    public void Continue()
    {
        if(!canClickButton || writingText)
        {
            return;
        }
        
        StartCoroutine(ContinueBehaviour());
    }

    IEnumerator ContinueBehaviour()
    {
        //text = "Sure, go on. You will fail eventually.";
        //yield return StartCoroutine(TypeSentence());

        //TurnButtons(false);

        //yield return new WaitForSeconds(2f);
        yield return null;

        string sceneName = SceneManager.GetActiveScene().name;
        switch (sceneName)
        {
            case "CatchFruit":
                sceneAfterScenario = Loader.Scene.CrossRoad;
                sceneToLoad = Loader.Scene.ScenarioPrint;
                Clock.GoingForward = true;
                loading = true;
                break;

            case "CrossRoad":
                sceneAfterScenario = Loader.Scene.OfficePacMan;
                sceneToLoad = Loader.Scene.ScenarioPrint;
                Clock.GoingForward = true;
                loading = true;
                break;

            case "OfficePacMan":
                sceneAfterScenario = Loader.Scene.MainMenu;
                sceneToLoad = Loader.Scene.ScenarioPrint;
                Clock.GoingForward = true;
                loading = true;
                break;
        }

        canClickButton = true;
    }

    public void AfterScenario()
    {
        sceneToLoad = sceneAfterScenario;
        Loader.ClockSkip = true;

        if (text.ToCharArray()[1] == "e".ToCharArray()[0])
        {
            sceneAfterScenario = Loader.Scene.CatchFruit;
        }

        Clock.GoingForward = true;
        loading = true;
    }

    public void GiveUp()
    {
        if(!canClickButton || writingText)
        {
            return;
        }

        if(writingText)
        {

        }
        
        StartCoroutine(GiveUpBehaviour());
    }

    IEnumerator GiveUpBehaviour()
    {
        //text = "That's right, give up.";
        //yield return StartCoroutine(TypeSentence());

        //TurnButtons(false);

        //yield return new WaitForSeconds(2f);
        yield return null;

        sceneToLoad = Loader.Scene.MainMenu;
        Clock.GoingForward = false;
        loading = true;

        canClickButton = true;
    }

    public void StartMiniGame()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        bool notScenario = false;

        switch (sceneName)
        {
            case "CatchFruit":
                string[] texts = new string[2];
                texts[0] = "so thoughtful, aren’t we." + System.Environment.NewLine + "did you start a fruit flight academy or are you just a moron? either way, you succeeded.";
                texts[1] = "try to save what you can. or not, what does it matter anyway";

                text = texts[Random.Range(0, texts.Length - 1)];
                notScenario = true;
                break;

            case "CrossRoad":
                text = "you know you could just willingly jump in front of one." + System.Environment.NewLine + "you might not have to see what else this crappy day has in store for you.";
                notScenario = true;
                break;

            case "OfficePacman":
                text = "you’ve done it now you worthless slacker." + System.Environment.NewLine + "you could run, but is it worth it." + System.Environment.NewLine + "he is going to get you one day, might as well let go.";
                notScenario = true;
                break;
        }

        if (notScenario)
        {
            StartCoroutine(TypeSentence("d"));
        }
    }

    public void Ready()
    {
        if(!canClickButton || writingText)
        {
            return;
        }

        string sceneName = SceneManager.GetActiveScene().name;
        switch (sceneName)
        {
            case "CatchFruit":
                StartCoroutine(FindObjectOfType<FruitSpawner>().SpawnFruit());
                GameObject.Find("StartScreen").SetActive(false);
                break;

            case "CrossRoad":
                GameObject.Find("StartScreen").SetActive(false);
                FindObjectOfType<CrossRoadPlayerController>().gameStarted = true;
                break;

            case "OfficePacman":
                GameObject.Find("StartScreen").SetActive(false);
                PlayerMovement.gameStarted = true;
                GameObject.Find("GameUI").transform.GetChild(0).gameObject.SetActive(true);
                break;

            case "CarLabyrinth":
                
                break;
        }
    }
}
