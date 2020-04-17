using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossRoadPlayerController : MonoBehaviour
{
    private Player input;
    private Animator anim;

    private Vector3 startPos;
    private Vector3 endPos;

    private float lerpTime;
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
            }
        };

        input.CrossRoad.Right.performed += ctx =>
        {
            Move();

            if (transform.position == endPos)
            {
                endPos = new Vector3(transform.position.x + 1f, transform.position.y, transform.position.z);
            }
        };

        input.CrossRoad.Up.performed += ctx =>
        {
            Move();

            if (transform.position == endPos)
            {
                endPos = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1f);
            }
        };

        input.CrossRoad.Down.performed += ctx =>
        {
            Move();

            if (transform.position == endPos)
            {
                endPos = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1f);
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
        perc = currentLerpTime / lerpTime;
        transform.position = Vector3.Lerp(startPos, endPos, perc);

        if (perc > 0.8f)
        {
            perc = 1f;
        }

        if (Mathf.Round(perc) == 1f)
        {
            anim.SetBool("Jumping", false);
        }
    }

    private void Move()
    {
        if (perc == 1f)
        {
            lerpTime = 1f;
            currentLerpTime = 0f;
            anim.SetBool("Jumping", true);
        }
    }
}
