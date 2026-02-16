using UnityEngine;

public class BallController : MonoBehaviour
{
    public float initialSpeed = 8f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Invoke("LaunchBall", 2f);
    }

    void LaunchBall()
    {
        float rand = Random.Range(0, 2);
        if(rand < 1){
            rb.AddForce(new Vector2(20, -15));
        } else {
            rb.AddForce(new Vector2(-20, -15));
        }

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.collider.CompareTag("Player")){
            Vector2 vel;
            vel.x = rb.linearVelocity.x;
            vel.y = (rb.linearVelocity.y / 2) + (coll.collider.attachedRigidbody.linearVelocity.y / 3);
            rb.linearVelocity = vel;
        }

    }

    public void ResetBall()
    {
    rb.linearVelocity = Vector2.zero;
    transform.position = Vector2.zero;

    Invoke("LaunchBall", 1f);
    }
}
