using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFreze : MonoBehaviour
{
    public bool freze;

    Vector3 deathPosition = Vector3.zero;

    // Update is called once per frame
    void Update()
    {
        if(freze)
        {
            if(deathPosition == Vector3.zero)
            {
                deathPosition = transform.position;
            }
            transform.position = deathPosition;
        }
    }
}
