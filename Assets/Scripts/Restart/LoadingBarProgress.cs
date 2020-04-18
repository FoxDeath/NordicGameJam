using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingBarProgress : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Loading());
    }

    IEnumerator Loading()
    {
        yield return new WaitForSeconds(3f);

        Loader.loadingFinished = true;
    }
}
