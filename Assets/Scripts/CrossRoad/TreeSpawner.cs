using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawner : MonoBehaviour
{
    [SerializeField] GameObject tree;

    [SerializeField] int aprxAmount = 15;

    void Start()
    {
        aprxAmount += Random.Range(-3, 3);

        for (int i = 0; i < aprxAmount; i++)
        {
            Instantiate(tree, new Vector3(transform.position.x + Random.Range(-22, 22), transform.position.y + 1.2f, transform.position.z), Quaternion.identity, transform);
        }
    }
}
