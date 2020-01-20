using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            RemovePlayerPrefs();
        }
    }

    public void NewGameButton()
    {
        SceneManager.LoadScene(3);
        PlayerPrefs.SetInt("_unlockedLevels", 1);
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

    private void RemovePlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("_unlockedLevels", 1);
    }
}
