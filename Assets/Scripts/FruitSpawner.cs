using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] fruit;
    [SerializeField, Range(0f, 100f)] float spawnRangeX;
    [SerializeField, Range(0f, 100f)] float spawnRangeY;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnFruit());
    }

    IEnumerator SpawnFruit()
    {
        Vector3 spawnPosition = new Vector3
        (
            Random.Range(-spawnRangeX, spawnRangeX),
            Random.Range(spawnRangeY - 2f, spawnRangeY),
            0f
        );

        GameObject tempFruit = Instantiate(fruit[Random.Range(0, fruit.Length)], spawnPosition, Quaternion.identity);

        yield return new WaitForSeconds(Random.Range(0.5f, 2f));
        yield return StartCoroutine(SpawnFruit());
    }
}
