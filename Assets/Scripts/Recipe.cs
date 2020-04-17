using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Recipe : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI bananaNumberText;
    [SerializeField] TextMeshProUGUI pearNumberText;
    [SerializeField] TextMeshProUGUI appleNumberText;
    
    private int bananaNumber;
    private int pearNumber;
    private int appleNumber;

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

        if(bananaNumber < 1)
        {
            EndGame();
        }

        if(appleNumber < 1)
        {
            EndGame();
        }

        if(pearNumber < 1)
        {
            EndGame();
        }
    }

    private void Victory()
    {
        return;
        //to do: Victory screen
    }

    public void EndGame()
    {
        return;
        //to do: Lose screen
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
