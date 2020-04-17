using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGenerator : MonoBehaviour
{
    private static TerrainGenerator instance;
    [SerializeField] List<GameObject> terrains = new List<GameObject>();

    private Vector3 currentPosition = new Vector3(0f, -1f, 0f);

    [SerializeField] int levelLength;

    public static TerrainGenerator GetInstance()
    {
        return instance;
    }

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        for (int i = 0; i <= levelLength; i++)
        {
            SpawnTerrain();
        }
    }

    public void SpawnTerrain()
    {
        GameObject currentTerrain = Instantiate(terrains[Random.Range(0, terrains.Count)], currentPosition, Quaternion.identity, transform);
        
        if (currentTerrain.CompareTag("Road"))
        {
            currentPosition.z += 2f;
        }
        else
        {
            currentPosition.z++;
        }
    }
}
