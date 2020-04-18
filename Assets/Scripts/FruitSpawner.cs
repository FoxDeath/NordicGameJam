using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] fruit;
    [SerializeField] GameObject[] notFruit;
    [SerializeField, Range(0f, 100f)] float spawnRangeX;
    [SerializeField, Range(0f, 100f)] float spawnRangeY;

    private bool first = true;

    public IEnumerator SpawnFruit()
    {
        Vector3 spawnPosition = new Vector3
        (
            Random.Range(-spawnRangeX, spawnRangeX),
            Random.Range(spawnRangeY - 2f, spawnRangeY),
            0f
        );

        if(Random.Range(1, 100) > 25)
        {
            GameObject tempFruit = Instantiate(fruit[Random.Range(0, fruit.Length)], spawnPosition, Random.rotation);
        }
        else
        {
            GameObject tempFruit = Instantiate(notFruit[Random.Range(0, notFruit.Length)], spawnPosition, Random.rotation);
        }

        yield return new WaitForSeconds(Random.Range(0.5f, 2f));
        yield return StartCoroutine(SpawnFruit());
    }
}
