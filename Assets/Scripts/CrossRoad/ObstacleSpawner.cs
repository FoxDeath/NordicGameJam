using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] GameObject spawnable;

    private Vector3 spawnPoint;

    [SerializeField] float spawnOffset = 5f;
    //hmaybe have a float for the minimum spawn rate???

    void Start()
    {
        if (Random.Range(0, 1) == 0)
        {
            spawnPoint = new Vector3(transform.position.x - 22f + spawnOffset, transform.position.y, transform.position.z);
        }
        else
        {
            spawnPoint = new Vector3(transform.position.x + 22f + spawnOffset, transform.position.y, transform.position.z);
        }
    }

    //set the spawn speed according to the speed and length of the spawnable so
    //that if you spawn 2 cars immediately after each other they should be right
    //after each other and not stuck together

    //either spawn the car right after the other one or leave a set amount of space after the other one

    //the spawn rate shouldnt be in time but in the number of possible free units between the cars

    //from the speed of the car get how fast it travels one unit and multiply that with the number of free
    //slots in between that the random generator puts out
}
