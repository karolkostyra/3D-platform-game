using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MouseCursorController
{
    [SerializeField] private GameObject pauseMenu;
    private bool isPaused;
    private CameraController cameraController;
    //private MouseCursorController mouseController;

    private void Start()
    {
        isPaused = false;
        cameraController = GameObject.FindObjectOfType<CameraController>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        cameraController.enabled = true;
        pauseMenu.SetActive(false);
        Lock();
        Hide();
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
        OnPauseMenuExit();
    }

    public void Pause()
    {
        cameraController.enabled = false;
        pauseMenu.SetActive(true);
        Unlock();
        Show();
        //Cursor.lockState = CursorLockMode.None;
        //Cursor.visible = true;
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void LoadMenu()
    {
        OnPauseMenuExit();
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        OnPauseMenuExit();
        Application.Quit();
    }

    private void OnPauseMenuExit()
    {
        Time.timeScale = 1f;
        isPaused = false;
    }
}
