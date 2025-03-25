using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public static SceneController sceneController { get; private set; }

    private int playerScore = 0;

    private void Awake()
    {
        if (sceneController != null && sceneController != this)
        {
            Destroy(gameObject);
            return;
        }

        sceneController = this;
        DontDestroyOnLoad(gameObject);
    }


    public void RecievePlayerScore(int score)
    {
        playerScore = score;
    }

    public void ChangeTheScene(string selectedScene)
    {
        SceneManager.LoadSceneAsync(selectedScene);
    }

    public int GetPlayerScore()
    {
        return playerScore;
    }
}
