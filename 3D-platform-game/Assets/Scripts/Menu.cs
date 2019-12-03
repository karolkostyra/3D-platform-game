using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    [SerializeField] private GUISkin skin;
    [SerializeField] private float buttonWidth = 200;
    [SerializeField] private float buttonHeight = 75;
    [SerializeField] private float buttonMargin = 20;

    private float centerOfWidth = Screen.width / 2;
    private float centerOfHeight = Screen.height / 2;


    void OnGUI()
    {
        GUI.skin = skin;

        GUIStyle playButton = new GUIStyle("button");
        playButton.fontSize = 30;

        GUIStyle quitButton = new GUIStyle("button");
        quitButton.fontSize = 30;

        GUI.Label(new Rect(centerOfWidth - 175, centerOfHeight - 300, 450, 450), "Unknown");

        if (GUI.Button(new Rect(centerOfWidth - 100, centerOfHeight - 50, buttonWidth, buttonHeight), "Play", playButton))
        {
            SceneManager.LoadScene(1);
        }
        if (GUI.Button(new Rect(centerOfWidth - 100, centerOfHeight + 50, buttonWidth, buttonHeight), "Quit", quitButton))
        {
            Application.Quit();
        }
    }
}
