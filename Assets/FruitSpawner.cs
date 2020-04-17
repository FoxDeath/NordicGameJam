using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    [SerializeField] GameObject fruit;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnFruit());
    }

    IEnumerator SpawnFruit()
    {
        Vector3 spawnPosition = new Vector3
        (
            Random.Range(-10f, 10f),
            Random.Range(6f, 8f),
            0f
        );

        GameObject tempFruit = Instantiate(fruit, spawnPosition, Quaternion.identity);

        yield return new WaitForSeconds(Random.Range(0.5f, 2f));
        yield return StartCoroutine(SpawnFruit());
    }
}
