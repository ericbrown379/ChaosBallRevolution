using UnityEngine;

public class BallScore : MonoBehaviour
{
    private GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnDestroy()
    {
        if (gameManager != null)
        {
            gameManager.BallScored();
        }
    }
}
