using Unity.VisualScripting;
using UnityEngine;

public class ScoreCanvas : MonoBehaviour
{
    [SerializeField] private int score;
    [SerializeField] private TMPro.TMP_Text scoreCounter;
    [SerializeField] private TMPro.TMP_Text timerCounter;

    [SerializeField] private float gameTimeLength;
    private bool gameIsRunning = false;

    private SceneController sceneController;

    private void Start()
    {
        score = 0;
        sceneController = FindAnyObjectByType<SceneController>();
        gameIsRunning = true;
    }

    private void Update()
    {
        scoreCounter.text = score.ToString();
        RunTheGame();

    }

    private void RunTheGame()
    {
        if (gameIsRunning)
        {
            gameTimeLength--;
            timerCounter.text = gameTimeLength.ToString();
            if (gameTimeLength <= 0)
            {
                EndTheGame();
            }
        }
    }

    public void AddPoints(int points)
    {
        score += points;
    }

    private void EndTheGame()
    {
        sceneController.RecievePlayerScore(score);
        sceneController.ChangeTheScene(GlobalRefs.GAMEOVER);
    }
}
