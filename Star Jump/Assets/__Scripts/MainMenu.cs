using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public void PlayMainMenu () {
        SceneManager.LoadScene ("Menu");
    }
    public void PlayGame () {
        SceneManager.LoadScene ("Level1");
    }
    public void PlayLevels () {
        SceneManager.LoadScene ("Levels");
    }
    public void PlayGame2 () {
        SceneManager.LoadScene ("Level2");
    }
    public void PlayGame3 () {
        SceneManager.LoadScene ("Level3");
    }
    public void QuitGame () {
        Application.Quit ();
    }

}