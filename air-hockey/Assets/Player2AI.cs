using UnityEngine;

public class Player2AI : MonoBehaviour
{
    public Transform ball;
    public float moveSpeed = 10f;
    public Vector2 minBounds;
    public Vector2 maxBounds;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (ball == null) return;

        Vector2 targetPosition = new Vector2(transform.position.x, ball.position.y);

        // Limita o movimento ao lado do Player 2
        targetPosition.x = Mathf.Clamp(targetPosition.x, minBounds.x, maxBounds.x);
        targetPosition.y = Mathf.Clamp(targetPosition.y, minBounds.y, maxBounds.y);

        Vector2 newPos = Vector2.Lerp(rb.position, targetPosition, moveSpeed * Time.fixedDeltaTime);
        rb.MovePosition(newPos);
    }
}
