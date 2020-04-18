using UnityEngine;
using UnityEngine.InputSystem.Interactions;

public class CrossRoadPlayerController : MonoBehaviour
{
    [SerializeField] Transform child;
    private Player input;
    private Animator anim;
    [SerializeField] AnimationCurve ac;

    private Vector3 startPos;
    private Vector3 endPos;
    private Vector3 startScale = new Vector3(1f, 1f, 1f);
    private Vector3 endScale = new Vector3(1f, 1f, 1f);

    [SerializeField] float lerpSpeed = 8;
    [SerializeField] float scaleSpeed = 4;
    [SerializeField] float scaleChange = 0.1f;
    private float currentLerpTime;
    private float currentScaleTime;
    private float perc = 1f;
    private float scalePerc;

    void Awake()
    {
        input = new Player();
        input.Enable();

        input.CrossRoad.Left.started += ctx =>
        {
            currentScaleTime = 0f;
            startScale = transform.localScale;
            endScale = new Vector3(transform.localScale.x + scaleChange, transform.localScale.y - scaleChange, transform.localScale.z);
        };

        input.CrossRoad.Left.canceled += ctx =>
        {
            if (perc >= 1.5f)
            {
                anim.Play("Jump");
                currentLerpTime = 0f;
                currentScaleTime = 0f;
                perc = 0f;
                startPos = transform.position;
                startScale = transform.localScale;
            }

            endScale = new Vector3(1f, 1f, 1f);

            if (transform.position == endPos)
            {
                endPos = new Vector3(transform.position.x - 1f, transform.position.y, transform.position.z);
                transform.rotation = Quaternion.Euler(0f, -90f, 0f);
            }
        };

        input.CrossRoad.Right.started += ctx =>
        {
            currentScaleTime = 0f;
            startScale = transform.localScale;
            endScale = new Vector3(transform.localScale.x + scaleChange, transform.localScale.y - scaleChange, transform.localScale.z);
        };

        input.CrossRoad.Right.canceled += ctx =>
        {
            if (perc >= 1.5f)
            {
                anim.Play("Jump");
                currentLerpTime = 0f;
                currentScaleTime = 0f;
                perc = 0f;
                startPos = transform.position;
                startScale = transform.localScale;
            }

            endScale = new Vector3(1f, 1f, 1f);

            if (transform.position == endPos)
            {
                endPos = new Vector3(transform.position.x + 1f, transform.position.y, transform.position.z);
                transform.rotation = Quaternion.Euler(0f, 90f, 0f);
            }
        };

        input.CrossRoad.Up.started += ctx =>
        {
            currentScaleTime = 0f;
            startScale = transform.localScale;
            endScale = new Vector3(transform.localScale.x + scaleChange, transform.localScale.y - scaleChange, transform.localScale.z);
        };

        input.CrossRoad.Up.canceled += ctx =>
        {
            if (perc >= 1.5f)
            {
                anim.Play("Jump");
                currentLerpTime = 0f;
                currentScaleTime = 0f;
                perc = 0f;
                startPos = transform.position;
                startScale = transform.localScale;
            }

            endScale = new Vector3(1f, 1f, 1f);

            if (transform.position == endPos)
            {
                endPos = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1f);
                transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            }
        };

        input.CrossRoad.Down.started += ctx =>
        {
            currentScaleTime = 0f;
            startScale = transform.localScale;
            endScale = new Vector3(transform.localScale.x + scaleChange, transform.localScale.y - scaleChange, transform.localScale.z);
        };

        input.CrossRoad.Down.canceled += ctx =>
        {
            if (perc >= 1.5f)
            {
                anim.Play("Jump");
                currentLerpTime = 0f;
                currentScaleTime = 0f;
                perc = 0f;
                startPos = transform.position;
                startScale = transform.localScale;
            }

            endScale = new Vector3(1f, 1f, 1f);

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
         currentLerpTime += Time.deltaTime * lerpSpeed;
         perc = currentLerpTime;
         transform.position = Vector3.Lerp(startPos, endPos, ac.Evaluate(perc));

         currentScaleTime += Time.deltaTime * scaleSpeed;
         scalePerc = currentScaleTime;
         child.transform.localScale = Vector3.Lerp(startScale, endScale, ac.Evaluate(scalePerc));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
