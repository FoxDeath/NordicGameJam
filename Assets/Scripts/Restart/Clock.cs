using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField] GameObject minute;
    [SerializeField] GameObject hour;

    public static bool GoingForward = true;

    void Update()
    {
        if(GoingForward)
        {
            minute.transform.Rotate(0f, 360f * Time.deltaTime, 0f);
            hour.transform.Rotate(0f, 30f * Time.deltaTime, 0f);
        }
        else
        {
            minute.transform.Rotate(0f, -360f * Time.deltaTime, 0f);
            hour.transform.Rotate(0f, -30f * Time.deltaTime, 0f);
        }

        if(transform.position.z > -0.5f)
        {
            transform.position -= new Vector3(0f, 0f, 34f * Time.deltaTime);
        }
        else
        {
            transform.position = new Vector3(0f, 1f, -1f);
        }
    }
}
