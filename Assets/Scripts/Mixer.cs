using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mixer : MonoBehaviour
{
    private void Awake() {
        FindObjectOfType<AudioManager>().Play("blender");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Recipe recipe = FindObjectOfType<Recipe>();

        if(other.CompareTag("Fruit"))
        {
            recipe.Substract(other.gameObject);
            Destroy(other.gameObject, 2f);
            StartCoroutine(Blend());
        }

        if(other.CompareTag("NotFruit"))
        {
            recipe.EndGame();
            Destroy(other.gameObject, 2f);
            StartCoroutine(Blend());
        }
    }

    IEnumerator Blend()
    {
        FindObjectOfType<AudioManager>().SetPitch("blender", 1.5f);
        FindObjectOfType<AudioManager>().SetVolume("blender", 0.3f);


        yield return new WaitForSeconds(2f);

        FindObjectOfType<AudioManager>().SetPitch("blender", 1f);
        FindObjectOfType<AudioManager>().SetVolume("blender", 0.1f);

    }
}
