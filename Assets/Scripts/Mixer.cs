using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mixer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Fruit"))
        {
            FindObjectOfType<Recipe>().Substract(other.gameObject);
            Destroy(other.gameObject);
        }
    }
}
