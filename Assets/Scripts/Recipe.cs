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
        if(gameEnded)
        {
            return;
        }

        FindObjectOfType<AudioManager>().StopAll();
        gameEnded = true;
        appleNumberText.transform.parent.parent.gameObject.SetActive(false);
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

        FindObjectOfType<AudioManager>().StopAll();
        gameEnded = true;
        appleNumberText.transform.parent.parent.gameObject.SetActive(false);
        tryAgainMenu.SetActive(true);
        MenuManager endGameManager = FindObjectOfType<MenuManager>();
        endGameManager.text = "Looks like you failed again you dimwit.";
        StartCoroutine(endGameManager.TypeSentence());
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
