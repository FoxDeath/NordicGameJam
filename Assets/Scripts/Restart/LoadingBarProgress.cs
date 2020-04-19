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
            AudioManager audioManager = FindObjectOfType<AudioManager>();

            if (Clock.GoingForward)
                audioManager.Play("clock");
            else
                audioManager.Play("clockReverse");

            yield return new WaitForSeconds(3f);

            audioManager.Stop("clock");
            audioManager.Stop("clockReverse");

            Loader.loadingFinished = true;
    }
}
