using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public Button[] listOfLevelButtons;
    private Transform content;

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

    public void LoadLevelByName(string levelName)
    {
        SceneManager.LoadScene(levelName);
        Cursor.lockState = CursorLockMode.Locked;
    }
}
