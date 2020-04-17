using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DrawLine : MonoBehaviour
{
    [SerializeField] GameObject linePrefab;
    private GameObject currentLine;
    
    private LineRenderer lineRenderer;
    private EdgeCollider2D edgeCollider;

    public List<Vector2> mousePossition;
    private Vector2 currentMousePossition;

    private Player playerInput;

    private bool mouseClicked = false;

    void Awake()
    {
        playerInput = new Player();
        playerInput.Enable();
    }

    void Update()
    {
        playerInput.CatchFruit.MousePossition.performed += context => 
        {
            currentMousePossition = context.ReadValue<Vector2>();
        };

        if(playerInput.CatchFruit.Click.triggered)
        {
            mouseClicked = true;
            CreateLine();
        }
        if(mouseClicked)
        {
            Vector2 tempMousePossition = Camera.main.ScreenToWorldPoint(currentMousePossition);
            if(Vector3.Distance(tempMousePossition, mousePossition[mousePossition.Count-1]) > 0.1f)
            {
                UpdateLine(tempMousePossition);
            }
        }

        playerInput.CatchFruit.Click.canceled += _ =>
        {
            mouseClicked = false;
            Destroy(currentLine);
        };
    }

    void CreateLine()
    {
        currentLine = Instantiate(linePrefab, Vector3.zero, Quaternion.identity);
        lineRenderer = currentLine.GetComponent<LineRenderer>();
        edgeCollider = currentLine.GetComponent<EdgeCollider2D>();

        mousePossition.Clear();
        mousePossition.Add(Camera.main.ScreenToWorldPoint(currentMousePossition));
        mousePossition.Add(Camera.main.ScreenToWorldPoint(currentMousePossition));

        lineRenderer.SetPosition(0, mousePossition[0]);
        lineRenderer.SetPosition(1, mousePossition[1]);
        
        edgeCollider.points = mousePossition.ToArray();
    }

    void UpdateLine(Vector3 newMousePos)
    {
        mousePossition.Add(newMousePos);

        lineRenderer.positionCount ++;
        lineRenderer.SetPosition(lineRenderer.positionCount-1, newMousePos);

        edgeCollider.points = mousePossition.ToArray();
    }
}
