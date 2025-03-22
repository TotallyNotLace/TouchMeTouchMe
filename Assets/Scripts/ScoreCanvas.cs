using UnityEngine;

public class ScoreCanvas : MonoBehaviour
{
    [SerializeField] private int score;
    [SerializeField] private TMPro.TMP_Text scoreCounter;

    private void Start()
    {
        score = 0;
    }

    private void Update()
    {
        scoreCounter.text = score.ToString();
    }

    public void AddPoints(int points)
    {
        score += points;
    }
}
