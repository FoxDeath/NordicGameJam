using UnityEngine;

public class PointScript : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            ScoreScript.AddScore();
            Destroy(gameObject);
        }
    }
}
