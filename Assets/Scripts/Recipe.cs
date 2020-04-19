using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Recipe : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI bananaNumberText;
    [SerializeField] TextMeshProUGUI pearNumberText;
    [SerializeField] TextMeshProUGUI appleNumberText;

    [SerializeField] GameObject tryAgainMenu;
    [SerializeField] GameObject winMenu;

    
    private int bananaNumber;
    private int pearNumber;
    private int appleNumber;

    private bool gameEnded = false;

    void Start()
    {
        bananaNumber = Random.Range(1, 5);
        pearNumber = Random.Range(1, 5);
        appleNumber = Random.Range(1, 5);

        bananaNumberText.text = bananaNumber.ToString();
        pearNumberText.text = pearNumber.ToString();
        appleNumberText.text = appleNumber.ToString();
    }

    void Update()
    {
        if(gameEnded)
        {
            return;
        }

        bananaNumberText.text = bananaNumber.ToString();
        pearNumberText.text = pearNumber.ToString();
        appleNumberText.text = appleNumber.ToString();

        CheckRecipe();
    }

    private void CheckRecipe()
    {
        if(bananaNumber == 0 && appleNumber == 0 && pearNumber == 0)
        {
            Victory();
        }

        if(bananaNumber < 0)
        {
            EndGame();
        }

        if(appleNumber < 0)
        {
            EndGame();
        }

        if(pearNumber < 0)
        {
            EndGame();
        }
    }

    private void Victory()
    {
        gameEnded = true;
        appleNumberText.transform.parent.parent.gameObject.SetActive(false);
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
        appleNumberText.transform.parent.parent.gameObject.SetActive(false);
        tryAgainMenu.SetActive(true);
        MenuManager endGameManager = FindObjectOfType<MenuManager>();

        string[] texts = new string[2];
        texts[0] = "marvellous start for the day ain’t it? just go back to sleep already.";
        texts[1] = "cheer up, you’ll get it tomorrow. or not.";

        StartCoroutine(endGameManager.TypeSentence("d"));
    }

    public void Substract(GameObject fruit)
    {
        Fruit tempFruit = fruit.GetComponent<Fruit>();
        switch (tempFruit.fruit)
        {
            case Fruit.Fruits.Apple:
                appleNumber --;
            break;
            case Fruit.Fruits.Pear:
                pearNumber --;
            break;
            case Fruit.Fruits.Banana:
                bananaNumber --;
            break;

            default:
            break;
        }
    }
}
