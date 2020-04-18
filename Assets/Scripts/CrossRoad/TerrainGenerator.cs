using System.Collections.Generic;
using UnityEngine;

public class TerrainGenerator : MonoBehaviour
{
    private static TerrainGenerator instance;

    [SerializeField] List<GameObject> terrains = new List<GameObject>();
    [SerializeField] GameObject lines;
    private GameObject currentTerrain;

    private Vector3 currentPosition = new Vector3(0f, -1f, 4f);

    [SerializeField] int levelLength;
    private int inARow;

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
        currentTerrain = GameObject.Find("Road");

        for (int i = 0; i <= levelLength; i++)
        {
            SpawnTerrain();
        }
    }

    public void SpawnTerrain()
    {
        GameObject previousTerrain = new GameObject();

        if (currentTerrain)
        {
            previousTerrain = currentTerrain;
        }

        currentTerrain = terrains[Random.Range(0, terrains.Count)];

        if (previousTerrain.tag == currentTerrain.tag)
        {
            if (previousTerrain.CompareTag("Road"))
            {
                Instantiate(lines, new Vector3(currentPosition.x, currentPosition.y, currentPosition.z - 1f), Quaternion.identity, transform);
            }
        }

        GameObject ins = Instantiate(currentTerrain, currentPosition, Quaternion.identity, transform);
        
        if (ins.CompareTag("Road"))
        {
            currentPosition.z += 2f;
        }
        else
        {
            currentPosition.z++;
        }
    }
}
