using UnityEngine;

public class GameOverCanvas : MonoBehaviour
{
    private int score;
    [SerializeField] private SceneController sceneController;
    [SerializeField] private TMPro.TMP_Text scoreCounter;

    private void Awake()
    {
        
    }

    private void Start()
    {
        sceneController = FindAnyObjectByType<SceneController>();
        Debug.Log("tried to set score");
        scoreCounter.text = sceneController.GetPlayerScore().ToString();
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void RestartGame()
    {
        sceneController.ChangeTheScene(GlobalRefs.HOUSE);
    }
}
