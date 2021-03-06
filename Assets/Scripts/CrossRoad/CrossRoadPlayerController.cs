﻿using UnityEngine;
using UnityEngine.InputSystem.Interactions;
using Cinemachine;

public class CrossRoadPlayerController : MonoBehaviour
{
    [SerializeField] Transform child;
    private Player input;
    private Animator anim;
    private ParticleSystem particle;
    [SerializeField] AnimationCurve ac;

    private Vector3 startPos;
    private Vector3 endPos;
    private Vector3 startScale = new Vector3(0.15f, 0.15f, 0.15f);
    private Vector3 endScale = new Vector3(0.15f, 0.15f, 0.15f);

    [SerializeField] float lerpSpeed = 8;
    [SerializeField] float scaleSpeed = 4;
    [SerializeField] float scaleChange = 0.1f;
    private float currentLerpTime;
    private float currentScaleTime;
    private float perc = 1f;
    private float scalePerc;

    [SerializeField] GameObject tryAgainMenu;
    [SerializeField] GameObject winMenu;

    private bool gameEnded = false;
    public bool gameStarted = false;

    void Awake()
    {
        input = new Player();
        input.Enable();

        input.CrossRoad.Left.started += ctx =>
        {
            currentScaleTime = 0f;
            startScale = child.localScale;
            endScale = new Vector3(child.localScale.x + scaleChange, child.localScale.y - scaleChange, child.localScale.z);
        };

        input.CrossRoad.Left.canceled += ctx =>
        {
            if (perc >= 1.5f)
            {
                FindObjectOfType<AudioManager>().Play("blop");
                if(!gameEnded)
                anim.Play("Jump");
                currentLerpTime = 0f;
                currentScaleTime = 0f;
                perc = 0f;
                startPos = transform.position;
                startScale = child.localScale;
            }

            endScale = new Vector3(0.15f, 0.15f, 0.15f);

            if (transform.position == endPos)
            {
                endPos = new Vector3(transform.position.x - 1f, transform.position.y, transform.position.z);
                transform.rotation = Quaternion.Euler(0f, -90f, 0f);
            }
        };

        input.CrossRoad.Right.started += ctx =>
        {
            currentScaleTime = 0f;
            startScale = child.localScale;
            endScale = new Vector3(child.localScale.x + scaleChange, child.localScale.y - scaleChange, child.localScale.z);
        };

        input.CrossRoad.Right.canceled += ctx =>
        {
            if (perc >= 1.5f)
            {
                FindObjectOfType<AudioManager>().Play("blop");
                if(!gameEnded)
                anim.Play("Jump");
                currentLerpTime = 0f;
                currentScaleTime = 0f;
                perc = 0f;
                startPos = transform.position;
                startScale = child.localScale;
            }

            endScale = new Vector3(0.15f, 0.15f, 0.15f);

            if (transform.position == endPos)
            {
                endPos = new Vector3(transform.position.x + 1f, transform.position.y, transform.position.z);
                transform.rotation = Quaternion.Euler(0f, 90f, 0f);
            }
        };

        input.CrossRoad.Up.started += ctx =>
        {
            currentScaleTime = 0f;
            startScale = child.localScale;
            endScale = new Vector3(child.localScale.x + scaleChange, child.localScale.y - scaleChange, child.localScale.z);
        };

        input.CrossRoad.Up.canceled += ctx =>
        {
            if (perc >= 1.5f)
            {
                FindObjectOfType<AudioManager>().Play("blop");
                if(!gameEnded)
                anim.Play("Jump");
                currentLerpTime = 0f;
                currentScaleTime = 0f;
                perc = 0f;
                startPos = transform.position;
                startScale = child.localScale;
            }

            endScale = new Vector3(0.15f, 0.15f, 0.15f);

            if (transform.position == endPos)
            {
                endPos = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1f);
                transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            }
        };

        input.CrossRoad.Down.started += ctx =>
        {
            currentScaleTime = 0f;
            startScale = child.localScale;
            endScale = new Vector3(child.localScale.x + scaleChange, child.localScale.y - scaleChange, child.localScale.z);
        };

        input.CrossRoad.Down.canceled += ctx =>
        {
            if (perc >= 1.5f)
            {
                FindObjectOfType<AudioManager>().Play("blop");        
                if(!gameEnded)
                anim.Play("Jump");
                currentLerpTime = 0f;
                currentScaleTime = 0f;
                perc = 0f;
                startPos = transform.position;
                startScale = child.localScale;
            }

            endScale = new Vector3(0.15f, 0.15f, 0.15f);

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
        particle = GetComponentInChildren<ParticleSystem>();
    }

    void FixedUpdate()
    {
        if(gameEnded || !gameStarted)
        {
            return;
        }

        AudioManager audioManager = FindObjectOfType<AudioManager>();

        if(!audioManager.IsPlaying("city"))
        {
            audioManager.Play("city");
        }

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
            particle.Play();
            EndGame();
            Destroy(transform.GetChild(0).gameObject);
        }

        if (other.CompareTag("Goal"))
        {
            Victory();
            Destroy(transform.GetChild(0).gameObject);
        }

        if (other.CompareTag("Restriction"))
        {
            endPos = startPos;
        }
    }

    private void Victory()
    {
        if(gameEnded)
        {
            return;
        }

        FindObjectOfType<AudioManager>().StopAll();        
        gameEnded = true;
        winMenu.SetActive(true);
        MenuManager endGameManager = FindObjectOfType<MenuManager>();
        FindObjectOfType<CameraFreze>().freze = true;

        string[] texts = new string[2];
        texts[0] = "so persistent, aren't we.";
        texts[1] = "do you really think there is anything better to come.";

        endGameManager.text = texts[Random.Range(0, texts.Length - 1)];
        StartCoroutine(endGameManager.TypeSentence("d"));
    }

    public void EndGame()
    {
        if(gameEnded)
        {
            return;
        }

        FindObjectOfType<AudioManager>().StopAll();        
        gameEnded = true;
        tryAgainMenu.SetActive(true);
        MenuManager endGameManager = FindObjectOfType<MenuManager>();
        FindObjectOfType<CameraFreze>().freze = true;

        string[] texts = new string[2];
        texts[0] = "you deserve it you know.";
        texts[1] = "i sincerely hope you did that intentionally.";

        endGameManager.text = texts[Random.Range(0, texts.Length - 1)];
        StartCoroutine(endGameManager.TypeSentence("d"));
    }

    private void OnDestroy() {
        input.Disable();
    }
}
