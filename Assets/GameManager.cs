using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int ballsInPlay = 4;

    public void BallScored()
    {
        ballsInPlay--;
        if (ballsInPlay <= 0)
        {
            Debug.Log("You Win!");
            RestartGame();
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}