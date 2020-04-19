using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 3f;

    private Input input;
    private Vector3 direction = Vector3.zero;

    public static bool gameStarted;

    void Awake()
    {
        gameStarted = false;

        input = new Input();
        input.Enable();

        input.Pacman.Up.performed += a =>
        {
            direction = Vector3.forward;
            transform.rotation = Quaternion.Euler(0f, -90f, 0f);
        };

        input.Pacman.Down.performed += a =>
        {
            direction = Vector3.forward * -1;
            transform.rotation = Quaternion.Euler(0f, 90f, 0f);
        };

        input.Pacman.Left.performed += a =>
        {
            direction = Vector3.left;
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        };
        
        input.Pacman.Right.performed += a =>
        {
            direction = Vector3.right;
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        };
    }

    void FixedUpdate()
    {
        if(!gameStarted || ScoreScript.gameEnded)
        {
            return;
        }

        Move();
    }

    void Move()
    {
        transform.position += direction * speed * Time.deltaTime;
    }
}
