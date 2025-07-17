using UnityEngine;

public class p1 : MonoBehaviour
{
    public float speed = 7f;
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveY = 0f;

        if (Input.GetKey(KeyCode.W))
            moveY = 1f;
        else if (Input.GetKey(KeyCode.S))
            moveY = -1f;

        Vector2 newPosition = rb.position + new Vector2(0f, moveY * speed * Time.deltaTime);
        rb.MovePosition(newPosition);
    }
}
