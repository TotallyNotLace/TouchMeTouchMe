using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNavigator : MonoBehaviour
{
    public void StartTheGame()
    {
        SceneManager.LoadSceneAsync("Afternoon");
    }
    public void QuitTheApp()
    {
        Application.Quit();
    }
}
