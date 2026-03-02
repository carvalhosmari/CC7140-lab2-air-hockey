using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] int playerScore1 = 0; // Pontuação do player 1
    [SerializeField] int playerScore2 = 0; // Pontuação do player 2


    public GUISkin layout;              // Fonte do placar
    GameObject theBall, theGoal1, theGoal2; // Referências para a bola e os gols

    void Start () 
    {
        theBall = GameObject.FindGameObjectWithTag("Ball"); // Busca a referência da bola
    }

    void OnGUI () 
    {
        GUI.skin = layout;
        GUI.Label(new Rect(Screen.width / 2 - 150 - 12, 20, 100, 100), "" + playerScore1);
        GUI.Label(new Rect(Screen.width / 2 + 150 + 12, 20, 100, 100), "" + playerScore2);

        if (GUI.Button(new Rect(Screen.width / 2 - 60, 35, 120, 53), "RESTART"))
        {
            playerScore1 = 0;
            playerScore2 = 0;
            theBall.SendMessage("RestartGame", null, SendMessageOptions.RequireReceiver);
        }
        if (playerScore1 == 10)
        {
            GUI.Label(new Rect(Screen.width / 2 - 150, 200, 2000, 1000), "PLAYER ONE WINS");
            theBall.SendMessage("ResetBall", null, SendMessageOptions.RequireReceiver);
        } else if (playerScore2 == 10)
        {
            GUI.Label(new Rect(Screen.width / 2 - 150, 200, 2000, 1000), "PLAYER TWO WINS");
            theBall.SendMessage("ResetBall", null, SendMessageOptions.RequireReceiver);
        }
    }

    public void Player1Scored()
    {
        playerScore1++;
    }

    public void Player2Scored()
    {
        playerScore2++;
    }

}
