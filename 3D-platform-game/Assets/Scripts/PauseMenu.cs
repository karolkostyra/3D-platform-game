using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    private bool isPaused;
    private CameraController cameraController;

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
        Cursor.lockState = CursorLockMode.Locked;
        OnPauseMenuExit();
    }

    public void Pause()
    {
        cameraController.enabled = false;
        pauseMenu.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
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
