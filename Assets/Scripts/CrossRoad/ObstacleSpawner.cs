using System.Collections;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    private Transform container;

    [SerializeField] GameObject spawnable;

    private Vector3 spawnPoint;

    [SerializeField] float spawnOffset = 5f;
    [SerializeField] float speed = 7f;
    private float xScale;

    [SerializeField] int minDist = 0;
    [SerializeField] int maxDist = 5;

    private bool canSpawn;

    void Start()
    {
        speed += Random.Range(-3, 3);

        container = GameObject.Find("Container").transform;
        xScale = spawnable.transform.Find("Mesh").localScale.x + 0.3f;

        if (Random.Range(0, 2) == 0)
        {
            spawnPoint = new Vector3(transform.position.x - 22f - spawnOffset, transform.position.y + 0.8f, transform.position.z);
        }
        else
        {
            spawnPoint = new Vector3(transform.position.x + 22f + spawnOffset, transform.position.y + 0.8f, transform.position.z);
        }

        StartCoroutine(SpawnBehaviour());
    }

    IEnumerator SpawnBehaviour()
    {
        while (!canSpawn)
        {
            Vector3 direction = new Vector3();
            Quaternion rotation = new Quaternion();

            if (spawnPoint.x < 0f)
            {
                direction = Vector3.right;
                rotation = Quaternion.Euler(0f, 0f, 0f);
            }
            else
            {
                direction = Vector3.left;
                rotation = Quaternion.Euler(0f, 180f, 0f);
            }

            ObstacleController oc = Instantiate(spawnable, spawnPoint, rotation, container).GetComponent<ObstacleController>();

            oc.SetDirection(direction);
            oc.SetSpeed(speed);
            oc.SetDestroyOffset(spawnOffset);

            float cooldown = 1 / speed * xScale * Random.Range(minDist, maxDist);

            yield return new WaitForSeconds(cooldown);
        }
    }

    public void SetCanSpawn(bool canSpawn)
    {
        this.canSpawn = canSpawn;
    }
}
