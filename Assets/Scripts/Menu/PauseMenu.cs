using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] private GameObject gameCanvas;

    public void Pause()
    {
        AudioManager.instance.PlaySFX(AudioManager.instance.buttons);
        pauseMenu.SetActive(true);
        gameCanvas.SetActive(false);
        Time.timeScale = 0;
    }

    public void Home()
    {
        AudioManager.instance.PlaySFX(AudioManager.instance.buttons);
        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1;
    }

    public void Resume()
    {
        AudioManager.instance.PlaySFX(AudioManager.instance.buttons);
        pauseMenu.SetActive(false);
        gameCanvas.SetActive(true);
        Time.timeScale = 1;
    }

    public void Restart()
    {
        AudioManager.instance.PlaySFX(AudioManager.instance.buttons);
        Score.scoreValue = 0;
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }
}
