using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mixer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Recipe recipe = FindObjectOfType<Recipe>();

        if(other.CompareTag("Fruit"))
        {
            recipe.Substract(other.gameObject);
            Destroy(other.gameObject, 2f);
        }

        if(other.CompareTag("NotFruit"))
        {
            recipe.EndGame();
            Destroy(other.gameObject, 2f);
        }
    }
}
