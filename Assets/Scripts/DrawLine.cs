using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{
    public GameObject linePrefab;
    public GameObject currentLine;
    
    public LineRenderer lineRenderer;
    public EdgeCollider2D edgeCollider;

    public List<Vector2> mousePossition;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            CreateLine();
        }
        if(Input.GetMouseButton(0))
        {
            Vector2 tempMousePossition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if(Vector3.Distance(tempMousePossition, mousePossition[mousePossition.Count-1]) > 0.1f)
            {
                UpdateLine(tempMousePossition);
            }
        }
    }

    void CreateLine()
    {
        currentLine = Instantiate(linePrefab, Vector3.zero, Quaternion.identity);
        lineRenderer = currentLine.GetComponent<LineRenderer>();
        edgeCollider = currentLine.GetComponent<EdgeCollider2D>();

        mousePossition.Clear();
        mousePossition.Add(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        mousePossition.Add(Camera.main.ScreenToWorldPoint(Input.mousePosition));

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
