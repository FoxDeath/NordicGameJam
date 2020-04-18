using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //[SerializeField] float speed = 3f;
    private float horizontal;
    private float vertical;

    private Player input;
    private Vector3 currPos;

    void Awake()
    {
        input = new Player();
        input.Enable();

        input.Pacman.Up.performed += a =>
        {
            transform.position += Vector3.forward;
            transform.rotation = Quaternion.Euler(0f, -90f, 0f);
        };

        input.Pacman.Down.performed += a =>
        {
            transform.position += Vector3.forward * -1;
            transform.rotation = Quaternion.Euler(0f, 90f, 0f);
        };

        input.Pacman.Left.performed += a =>
        {
            transform.position += Vector3.left;
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        };
        
        input.Pacman.Right.performed += a =>
        {
            transform.position += Vector3.right;
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        };
    }

    void Start()
    {
        currPos = transform.position;
    }

    void FixedUpdate()
    {
        horizontal = currPos.x;
        vertical = currPos.y;
    }
}
