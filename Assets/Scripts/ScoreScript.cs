using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int scoreValue = 0;
    private int maxScore;
    private Text score;

    public static bool gameEnded;

    [SerializeField] GameObject tryAgainMenu;
    [SerializeField] GameObject winMenu;

    private void Awake() {
        gameEnded = false;
    }

    void Start()
    {
        score = GetComponent<Text>();
        maxScore = FindObjectsOfType<PointScript>().Length;
    }

    void Update()
    {
        score.text = "Score: " + scoreValue;

        if(scoreValue == maxScore)
        {
            Victory();
        }
    }

    private void Victory()
    {
        if(gameEnded || ScoreScript.gameEnded)
        {
            return;
        }
        
        gameEnded = true;
        winMenu.SetActive(true);
        MenuManager endGameManager = FindObjectOfType<MenuManager>();

        string[] texts = new string[2];
        texts[0] = "so persistent, aren't we.";
        texts[1] = "do you really think there is anything better to come.";

        endGameManager.text = texts[Random.Range(0, texts.Length - 1)];
        StartCoroutine(endGameManager.TypeSentence("d"));
    }

    public void EndGame()
    {
        if(gameEnded)
        {
            return;
        }

        gameEnded = true;
        tryAgainMenu.SetActive(true);
        MenuManager endGameManager = FindObjectOfType<MenuManager>();

        string[] texts = new string[2];
        texts[0] = "and you thought you were off the hook.";
        texts[1] = "you had enough yet.";

        StartCoroutine(endGameManager.TypeSentence("d"));
    }

    public static void AddScore()
    {
        scoreValue++;
    }
}
