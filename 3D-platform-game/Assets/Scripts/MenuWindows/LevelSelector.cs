using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelector : MouseCursorController
{
    public Button[] listOfLevelButtons;
    private Transform content;
    private MouseCursorController mouseController;

    private void Start()
    {
        int unlockedLevels = PlayerPrefs.GetInt("_unlockedLevels");

        for(int i=0; i < listOfLevelButtons.Length; i++)
        {
            if(i+1 > unlockedLevels)
            {
                listOfLevelButtons[i].interactable = false;
            }
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }

    public void LoadLevelByName(string levelName)
    {
        SceneManager.LoadScene(levelName);
        Lock();
        Hide();
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
    }
}
