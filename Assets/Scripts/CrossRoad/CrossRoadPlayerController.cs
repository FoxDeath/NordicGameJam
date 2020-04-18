using UnityEngine;

public class CrossRoadPlayerController : MonoBehaviour
{
    private Player input;
    private Animator anim;

    private Vector3 startPos;
    private Vector3 endPos;

    private float currentLerpTime;
    private float perc = 1f;

    void Awake()
    {
        input = new Player();
        input.Enable();

        input.CrossRoad.Left.performed += ctx =>
        {
            Move();

            if (transform.position == endPos)
            {
                endPos = new Vector3(transform.position.x - 1f, transform.position.y, transform.position.z);
                transform.rotation = Quaternion.Euler(0f, -90f, 0f);
            }
        };

        input.CrossRoad.Right.performed += ctx =>
        {
            Move();

            if (transform.position == endPos)
            {
                endPos = new Vector3(transform.position.x + 1f, transform.position.y, transform.position.z);
                transform.rotation = Quaternion.Euler(0f, 90f, 0f);
            }
        };

        input.CrossRoad.Up.performed += ctx =>
        {
            Move();

            if (transform.position == endPos)
            {
                endPos = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1f);
                transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            }
        };

        input.CrossRoad.Down.performed += ctx =>
        {
            Move();

            if (transform.position == endPos)
            {
                endPos = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1f);
                transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            }
        };

    }

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        startPos = transform.position;
        currentLerpTime += Time.deltaTime * 5f;
        perc = currentLerpTime;
        transform.position = Vector3.Lerp(startPos, endPos, perc);

        if (perc > 0.8f)
        {
            perc = 1f;
        }
    }

    private void Move()
    {
        if (perc == 1f)
        {
            currentLerpTime = 0f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
