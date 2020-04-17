using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    private bool onLine = false;
    
    public enum Fruits
    {
        Banana,
        Apple,
        Pear
    };

    public Fruits fruit;

    void Start()
    {
        StartCoroutine(Destroy());
    }

    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(5f);

        if(!onLine)
        {
            Destroy(gameObject);
        }
        else
        {
            yield return StartCoroutine(Destroy());
        }
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag("Line"))
        {
            onLine = true;
        }
    }
    private void OnCollisionExit2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag("Line"))
        {
            onLine = false;
        }
    }
}
