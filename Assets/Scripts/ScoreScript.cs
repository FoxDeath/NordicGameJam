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
        endGameManager.text = "You managed to do it somehow this time.";
        StartCoroutine(endGameManager.TypeSentence());
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
        endGameManager.text = "Looks like you failed again you dimwit.";
        StartCoroutine(endGameManager.TypeSentence());
    }

    public static void AddScore()
    {
        scoreValue++;
    }
}
