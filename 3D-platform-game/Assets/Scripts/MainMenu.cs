using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    [SerializeField] private GUISkin skin;
    [SerializeField] private float buttonWidth = 250;
    [SerializeField] private float buttonHeight = 100;
    [SerializeField] private float buttonMargin = 60;

    private float centerOfWidth;
    private float centerOfHeight;


    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;

        buttonWidth = (buttonWidth * Screen.width) / 1920;
        buttonHeight = (buttonHeight * Screen.height) / 1080;
        buttonMargin = (buttonMargin * Screen.height) / 1080;

        centerOfWidth = Screen.width / 2;
        centerOfHeight = Screen.height / 2;
    }

    public void NewGameButton()
    {
        SceneManager.LoadScene(2);
        PlayerPrefs.SetInt("_unlockedLevels", 1);
    }

    public void LevelSelectButton()
    {
        SceneManager.LoadScene(1);
    }

    public void SettingsButton()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    /*
    void OnGUI()
    {
        GUI.skin = skin;

        GUIStyle playButton = new GUIStyle("button");
        playButton.fontSize = 30;

        GUIStyle quitButton = new GUIStyle("button");
        quitButton.fontSize = 30;

        GUI.Label(new Rect(centerOfWidth-175, centerOfHeight-300, 450, 450), "Unknown");

        if (GUI.Button(new Rect(centerOfWidth-buttonWidth/2, centerOfHeight-50, buttonWidth, buttonHeight), "Play", playButton))
        {
            SceneManager.LoadScene(1);
        }
        if (GUI.Button(new Rect(centerOfWidth-buttonWidth/2, centerOfHeight+50, buttonWidth, buttonHeight), "Quit", quitButton))
        {
            Application.Quit();
        }
    }
    */
}
