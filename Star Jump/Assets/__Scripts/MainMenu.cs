using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    int sceneIndex = 1;
    public void PlayMainMenu () {
        SceneManager.LoadScene ("Menu");
    }
    public void PlayGame () {
        sceneIndex = PlayerPrefs.GetInt ("sceneIndex", 1);
        if (sceneIndex == 1) {
            SceneManager.LoadScene ("Level1");
        } else if (sceneIndex == 2) {
            SceneManager.LoadScene ("Level2");
        } else if (sceneIndex == 3) {
            SceneManager.LoadScene ("Level3");
        } else SceneManager.LoadScene ("Level1");
    }
    public void PlayGame1 () {
        SceneManager.LoadScene ("Level1");
        PlayerPrefs.SetInt ("sceneIndex", 1);
    }
    public void PlayGame2 () {
        SceneManager.LoadScene ("Level2");
        PlayerPrefs.SetInt ("sceneIndex", 2);
    }
    public void PlayGame3 () {
        SceneManager.LoadScene ("Level3");
        PlayerPrefs.SetInt ("sceneIndex", 3);
    }
    public void PlayLevels () {
        SceneManager.LoadScene ("Levels");
    }
    public void QuitGame () {
        Application.Quit ();
    }

}