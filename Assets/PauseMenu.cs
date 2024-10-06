using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused;
    public KeyCode pauseButton = KeyCode.Escape;

    public GameObject pauseMenuUI;

    private void Update()
    {
        if (Input.GetKeyDown(pauseButton))
        {
            if (!gameIsPaused)
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }
    private void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }
}
