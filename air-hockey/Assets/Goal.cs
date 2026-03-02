using UnityEngine;

public class Goal : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.CompareTag("Ball")){
            if(gameObject.name == "Goal1"){
                GameManager.Instance.Player2Scored();
            } else {
                GameManager.Instance.Player1Scored();
            }
        }
    }
}
