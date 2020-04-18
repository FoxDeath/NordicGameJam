using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TerrainGenerator : MonoBehaviour
{
    private static TerrainGenerator instance;

    [SerializeField] List<GameObject> terrains = new List<GameObject>();
    [SerializeField] GameObject lines;
    private GameObject previousTerrain;
    private GameObject currentTerrain;

    private Vector3 currentPosition = new Vector3(0f, -1f, 4f);

    [SerializeField] int levelLength;
    [SerializeField] int maxRoadsAfterAnother = 3;
    [SerializeField] int maxPavementsAfterAnother = 2;
    [SerializeField] int maxTracksAfterAnother = 3;


    private List<string> terrainArray = new List<string>();

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
        currentTerrain = terrains.Where(obj => obj.tag == "Road").SingleOrDefault();
        terrainArray.Add("r");

        for (int i = 0; i <= levelLength; i++)
        {
            SpawnTerrain();
        }
    }

    public void SpawnTerrain()
    {
        previousTerrain = currentTerrain;
        currentTerrain = terrains[Random.Range(0, terrains.Count)];

        if (currentTerrain == previousTerrain)
        {
            int inARow = 0;

            if (currentTerrain.CompareTag("Road"))
            {
                if (terrainArray.Count > maxRoadsAfterAnother)
                {
                    for (int i = 1; i <= maxRoadsAfterAnother; i++)
                    {
                        if (terrainArray[terrainArray.Count - i].Equals("r"))
                        {
                            inARow++;
                        }
                    }

                    if (inARow >= maxRoadsAfterAnother)
                    {
                        List<GameObject> availableTerrains = new List<GameObject>();

                        foreach (GameObject o in terrains)
                        {
                            if (!currentTerrain.CompareTag(o.tag))
                            {
                                availableTerrains.Add(o);
                            }
                        }

                        currentTerrain = availableTerrains[Random.Range(0, availableTerrains.Count)];
                    }
                }
            }
            else if (currentTerrain.CompareTag("Pavement"))
            {
                if (terrainArray.Count > maxPavementsAfterAnother)
                {
                    for (int i = 1; i <= maxPavementsAfterAnother; i++)
                    {
                        if (terrainArray[terrainArray.Count - i].Equals("p"))
                        {
                            inARow++;
                        }
                    }

                    if (inARow >= maxPavementsAfterAnother)
                    {
                        List<GameObject> availableTerrains = new List<GameObject>();

                        foreach (GameObject o in terrains)
                        {
                            if (!currentTerrain.CompareTag(o.tag))
                            {
                                availableTerrains.Add(o);
                            }
                        }

                        currentTerrain = availableTerrains[Random.Range(0, availableTerrains.Count)];
                    }
                }
            }
            else if (currentTerrain.CompareTag("Tracks"))
            {
                if (terrainArray.Count > maxTracksAfterAnother)
                {
                    for (int i = 1; i <= maxTracksAfterAnother; i++)
                    {
                        if (terrainArray[terrainArray.Count - i].Equals("t"))
                        {
                            inARow++;
                        }
                    }

                    if (inARow >= maxTracksAfterAnother)
                    {
                        List<GameObject> availableTerrains = new List<GameObject>();

                        foreach (GameObject o in terrains)
                        {
                            if (!currentTerrain.CompareTag(o.tag))
                            {
                                availableTerrains.Add(o);
                            }
                        }

                        currentTerrain = availableTerrains[Random.Range(0, availableTerrains.Count)];
                    }
                }
            }
        }

        if (previousTerrain.tag == currentTerrain.tag && previousTerrain.CompareTag("Road"))
        {
            Instantiate(lines, new Vector3(currentPosition.x, currentPosition.y, currentPosition.z - 1f), Quaternion.identity, transform);
        }

        GameObject ins = Instantiate(currentTerrain, currentPosition, Quaternion.identity, transform);

        if (ins.CompareTag("Road"))
        {
            terrainArray.Add("r");
        }
        else if (ins.CompareTag("Pavement"))
        {
            terrainArray.Add("p");
        }
        else if (ins.CompareTag("Tracks"))
        {
            terrainArray.Add("t");
        }

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
