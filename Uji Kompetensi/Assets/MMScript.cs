using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MMScript : MonoBehaviour
{
    public GameObject pauseUI;

    public void StartGame()
    {
        AudioManager.instance.PlaySFX("ClickButton");
        SceneManager.LoadScene("Game");
        AudioManager.instance.PlayMusic("BGMGameplay");
    }

    public void ExitGame()
    {
        AudioManager.instance.PlaySFX("ClickButton");
        Application.Quit();
        Debug.Log("Quit Game");
    }

    public void toMainMenu()
    {
        AudioManager.instance.PlaySFX("ClickButton");
        SceneManager.LoadScene("MainMenu");
    }

    public void PauseMenu()
    {
        pauseUI.SetActive(true);
        Time.timeScale = 0f;
        AudioManager.instance.PlaySFX("ClickButton");
    }

    public void ResumeGame()
    {
        pauseUI.SetActive(false);
        Time.timeScale = 1f;
        AudioManager.instance.PlaySFX("ClickButton");
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
