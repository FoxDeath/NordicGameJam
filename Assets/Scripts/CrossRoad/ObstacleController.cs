using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    private float speed;
    private Vector3 direction;

    void FixedUpdate()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);

        if (Mathf.Abs(transform.position.x) > 30f)
        {
            Destroy(gameObject);
        }
    }

    public void SetSpeed(float speed)
    {
        this.speed = speed;
    }

    public void SetDirection(Vector3 direction)
    {
        this.direction = direction;
    }
}
