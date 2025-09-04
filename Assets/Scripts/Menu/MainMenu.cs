using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    AudioManager audioManager;

    private void Start()
    {
        audioManager = AudioManager.instance;
    }

    public void PlayGame()
    {
        audioManager.PlaySFX(audioManager.buttons);
        Score.scoreValue = 0;
        SceneManager.LoadScene("SampleScene");
    }

    public void Settings()
    {
        audioManager.PlaySFX(audioManager.buttons);
        SceneManager.LoadScene("Settings");
    }

    public void QuitGame()
    {
        audioManager.PlaySFX(audioManager.buttons);
        Application.Quit();
    }

}
