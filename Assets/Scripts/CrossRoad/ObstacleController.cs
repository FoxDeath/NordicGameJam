using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    private Vector3 direction;

    private float speed;
    private float destroyOffset = 666f;

    void FixedUpdate()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);

        if (Mathf.Abs(transform.position.x) > 25f + destroyOffset && destroyOffset != 666f)
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

    public void SetDestroyOffset(float destroyOffset)
    {
        this.destroyOffset = destroyOffset;
    }
}
