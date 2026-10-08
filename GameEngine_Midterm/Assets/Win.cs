using UnityEngine;

public class Win : MonoBehaviour
{
    private int score = 0;
    private const int winScore = 1;
    public GameObject Player;
    void Start()
    {
        Debug.Log("game start: Press space to win");
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            score++;
        }
        if (score >= winScore)
        {
            Debug.Log("You win");

            Player.SetActive(false);
        }
    }
}
