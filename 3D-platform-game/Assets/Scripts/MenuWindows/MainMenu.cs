using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MouseCursorController
{
    private MouseCursorController mouseController;

    private void Start()
    {
        Unlock();
        //Cursor.lockState = CursorLockMode.None;
    }

    public void NewGameButton()
    {
        SceneManager.LoadScene(3);
        PlayerPrefs.SetInt("_unlockedLevels", 1);
        Hide();
    }

    public void LevelSelectButton()
    {
        SceneManager.LoadScene(1);
    }

    public void SettingsButton()
    {
        SceneManager.LoadScene(2);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
