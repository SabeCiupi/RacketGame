using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        Score.scoreValue = 0;
        SceneManager.LoadScene("SampleScene");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
