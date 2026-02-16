using UnityEngine;

public class Player1Controller : MonoBehaviour
{
    public float speed = 15.0f;             // Define a velocidade da raquete
    public float boundY = 2.25f;            // Define os limites em Y
    private Rigidbody2D rb2d;     
    
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector3 playerPos = transform.position;
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector3 dir = mousePos - playerPos;
        dir.Normalize();

        Vector3 speedVec = dir * speed;

        var vel = rb2d.linearVelocity;
        vel.x = speedVec.x;
        vel.y = speedVec.y;
        rb2d.linearVelocity = vel;

    }
}
