using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingsManager : MonoBehaviour
{
    [SerializeField] private Toggle toggle;
    [SerializeField] private Dropdown resolutionDropDown;
    Resolution[] resolutions;

    int firstRunTheGame;

    private void Awake()
    {
        if (Screen.fullScreen == true)
        {
            toggle.isOn = true;
        }
        else
        {
            toggle.isOn = false;
        }
    }

    private void Start()
    {
        int currentResolutionIndex = 0;
        firstRunTheGame = PlayerPrefs.GetInt("firstRun");
        Debug.Log("FRIST RUN: " + firstRunTheGame);
        if (firstRunTheGame == 1)
        {
            currentResolutionIndex = PlayerPrefs.GetInt("resolutionIndex");
        }

        resolutions = Screen.resolutions;

        resolutionDropDown.ClearOptions();
        List<string> options = new List<string>();

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if (firstRunTheGame == 0 &&
               resolutions[i].width == Screen.currentResolution.width &&
               resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }
        resolutionDropDown.AddOptions(options);
        resolutionDropDown.value = currentResolutionIndex;
        resolutionDropDown.RefreshShownValue();
        if (firstRunTheGame == 0)
        {
            firstRunTheGame = 1;
            PlayerPrefs.SetInt("firstRun", 1);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
        SaveCurrentResolution(resolutionIndex);
    }

    private void SaveCurrentResolution(int index)
    {
        PlayerPrefs.SetInt("resolutionIndex", index);
    }

    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
        Debug.Log(isFullScreen);
    }
}
