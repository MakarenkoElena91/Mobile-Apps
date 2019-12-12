using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
 using UnityEditor;
#endif

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenu;
    public GameObject mainScreen;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (GameIsPaused)
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
        pauseMenu.SetActive(false);
        mainScreen.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()

    {
        pauseMenu.SetActive(true);
        mainScreen.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void PlayMainMenu()
    {

        SceneManager.LoadScene("Menu");
        GameIsPaused = false;
        Time.timeScale = 1f;

    }

    public void QuitGame()
    {
        Application.Quit();

        // #if UNITY_EDITOR
        // UnityEditor.EditorApplication.isPlaying = false;
        // #endif

    }
}
