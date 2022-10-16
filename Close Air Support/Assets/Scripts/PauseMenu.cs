using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool gameisPaused = false;
    public GameObject pauseMenuUI;

    public void Start()
    {
        Time.timeScale = 1f;
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {


            if(gameisPaused == true)
            {
                Cursor.lockState = CursorLockMode.Locked;
                Resume();
            }
            else
            {
                //DISABLE MOUSE AND MAKE IT INVISIBLE
                Cursor.lockState = CursorLockMode.None;
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameisPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameisPaused = true;
    }
}
